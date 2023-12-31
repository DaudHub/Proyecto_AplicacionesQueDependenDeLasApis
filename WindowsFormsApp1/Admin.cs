﻿using MySqlConnector.Authentication;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {

        string username;
        string password;

        public Admin(string username, string password)
        {
            InitializeComponent();
            lblUsuario.Text = username;
            this.username = username;
            this.password = password;
            webMapa.ScriptErrorsSuppressed = true;
            webMapa.ScrollBarsEnabled = false;
        }

        private async void Admin_Load(object sender, EventArgs e)
        {
            if (!await ObtainToken(username, password))
            {
                this.Hide();
                Login.login.Show();
                this.Dispose();
            }
            try
            {
                UpdateElements();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnlCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.login.Show();
            this.Dispose();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            pnlCerrarSesion_Click(sender, e);
        }

        public async Task<bool> ObtainToken(string username, string password)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var bodyContent = new
                    {
                        Username = username,
                        Password = password,
                        Name = "",
                        Surname = "",
                        Role = "3"
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5077/api/gettoken", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener token: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener token: {responseBody.message}");
                    else Program.Token = responseBody.token;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        
        private async Task<List<dynamic>> GetRoute()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var bodyContent = new
                    {
                        User = username,
                        Password = password,
                        Token = Program.Token
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync($"http://localhost:5284/route", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al calcular la ruta: el servidor no responde correctamente");
                    dynamic responseBody = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener la ruta: {responseBody.message}");
                    return new List<dynamic>(responseBody.route);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<dynamic>();
            }
        }

        private async void cbxLote_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var bodyContent = new
                    {
                        User = username,
                        Password = password,
                        Token = Program.Token
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    dynamic response = await client.PostAsync("http://localhost:5284/viewbundles", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener paquetes: el servidor no responde correctamente");
                    dynamic responseBody = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception("Error al obtener paquetes");
                    cbxLote.Items.Clear();
                    foreach (var item in responseBody.bundles)
                    {
                        cbxLote.Items.Add(item.id.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void pnlConfirmar_Click(object sender, EventArgs e)
        {
            try {
                using (var client = new HttpClient())
                {
                    var bodyContent = new
                    {
                        Credentials = new
                        {
                            User = username,
                            Password = password,
                            Token = Program.Token
                        },
                        Element = int.Parse(cbxLote.SelectedItem.ToString())
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    dynamic response = await client.PostAsync("http://localhost:5284/confirm", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("error al confirmar la entrega: el servidor no responde correctamente");
                    dynamic responseBody = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al confirmar la entrega: {responseBody.message}{responseBody.exception}");
                    UpdateElements();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblConfirmar_Click(object sender, EventArgs e)
        {
            pnlConfirmar_Click(pnlConfirmar, e);
        }

        private async void UpdateElements()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var bodyContent = new
                    {
                        User = username,
                        Password = password,
                        Token = Program.Token
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5284/viewbundles", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al cargar lotes: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception("Error al cargar lotes: error de autenticación");
                    tblLotes.Rows.Clear();
                    foreach (var item in responseBody.bundles)
                    {
                        tblLotes.Rows.Add(item.id, item.deposit, item.street, item.number);
                    }
                    var route = await GetRoute();
                    string url = GetMapUrl(route);
                    Console.WriteLine(url);
                    webMapa.Navigate(url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string GetMapUrl(List<dynamic> coordinates)
        {
            try
            {
                string url = string.Empty;
                if (coordinates.Count < 1) return url;
                if (coordinates.Count == 1)
                {
                    url = $"https://dev.virtualearth.net/REST/v1/Imagery/Map/Road/{coordinates[0].coordinateX},{coordinates[0].coordinateY}/16?&pushpin={coordinates[0].coordinateX},{coordinates[0].coordinateY}&key=AjVIkFx1Wg4hG7mYImVk4euyiXWwBkDGSj1yUTi6_Oq-eTC_03IxeWatzN8wItJ4&";
                    return url;
                }
                url = "https://dev.virtualearth.net/REST/v1/Imagery/Map/Road/Routes/Driving?";
                for (int i = 0; i < coordinates.Count; i++)
                {
                    url += $"waypoint.{i + 1}={coordinates[i].coordinateX},{coordinates[i].coordinateY}&";
                }
                url += "key=AjVIkFx1Wg4hG7mYImVk4euyiXWwBkDGSj1yUTi6_Oq-eTC_03IxeWatzN8wItJ4";
                return url;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return string.Empty;
            }
        }

        private void webMapa_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            HtmlElement body = webMapa.Document.GetElementsByTagName("body")[0];
            body.Style = "padding: 0; margin: 0;";
            HtmlElementCollection images = webMapa.Document.Body.GetElementsByTagName("img");
            foreach (HtmlElement img in images) img.Style = "margin: 0px !important;";
        }
    }
}
