using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClientes
{
    public partial class Form1 : Form
    {
        private String username;
        private String password;

        public Form1(String user, String pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
            lblNombre.Text = user;
        }

        public async void Form1_Load(object sender, EventArgs e)
        {
            if (!await ObtainToken(username, password)) { this.Dispose(); Login.login.Show(); }
            List<dynamic> collection = await GetPackages(username, password);
            foreach (var item in collection)
            {
                tblLotes.Rows.Add(item.id, item.state, item.lote, item.plate, item.driver, item.date);
            }
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
                        Role = "4"
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

        public async Task<List<dynamic>> GetPackages(string username, string password)
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
                    var response = await client.PostAsync($"http://localhost:5284/mypackages", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener paquetes: el servidor no responde correctamente");
                    var responseBody = (dynamic) JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener paquetes: {responseBody.message}");
                    return responseBody.packages.ToObject<List<object>>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<dynamic>();
            }           

        }

        private async void pnlConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = await GetPackages(username, password);
                tblLotes.Rows.Clear();
                foreach (var item in collection)
                    if (item.id == txtIdLote.Text)
                        tblLotes.Rows.Add(item.id, item.state, item.lote, item.plate, item.driver, item.date);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void lblConfirmar_Click(object sender, EventArgs e)
        {
            pnlConfirmar_Click (sender, e);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void txtIdLote_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtIdLote.Text == "")
                {
                    List<dynamic> collection = await GetPackages(username, password);
                    foreach (var item in collection)
                    {
                        tblLotes.Rows.Add(item.id, item.state, item.lote, item.plate, item.driver, item.date);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void pnlCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login.login.Show();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            pnlCerrarSesion_Click(sender, e);
        }

        
    }
}
