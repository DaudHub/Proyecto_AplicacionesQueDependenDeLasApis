using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Lotes : UserControl
    {
        string username;
        string password;

        public Lotes(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private async void pnlCrearLote_Click(object sender, EventArgs e)
        {
            try
            {
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
                        Element = int.Parse(txtIdLote.Text) 
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5173/newbundle", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al crear lote: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al crear lote: {responseBody.message} {responseBody.exception}");
                    MessageBox.Show("lote creado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblCrear_Click(object sender, EventArgs e)
        {
            pnlCrearLote_Click(pnlCrearLote, e);
        }

        private async void pnlAgregarPaquete_Click(object sender, EventArgs e)
        {
            try
            {
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
                        Element = new
                        {
                            BundleID = int.Parse(txtIdLoteAgregar.Text),
                            PackageID = int.Parse(txtIdAgregarPaquete.Text)
                        }
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5173/assignpackage", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al asignar paquete: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al asignar paquete: {responseBody.message} {responseBody.exception}");
                    MessageBox.Show("paquete asignado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblAgregarPaquete_Click(object sender, EventArgs e)
        {
            pnlAgregarPaquete_Click(pnlAgregarPaquete, e);
        }

        private async void IDLote_DropDown(object sender, EventArgs e)
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
                    var response = await client.PostAsync("http://localhost:5173/bundles", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener lotes: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener lotes: {responseBody.message} {responseBody.exception}");
                    cbxIdLote.Items.Clear();
                    foreach (var item in responseBody.bundles)
                    {
                        cbxIdLote.Items.Add(item.bundleID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void cbxIdLote_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var bodyContent = new {
                        Credentials = new {
                            User = username,
                            Password = password,
                            Token = Program.Token
                        },
                        Element = int.Parse(cbxIdLote.SelectedItem.ToString())
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5173/packagesinbundle", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener paquetes: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener paquetes: {responseBody.message} {responseBody.exception}");
                    tblPaquetes.Rows.Clear();
                    foreach (var item in responseBody.packages)
                    {
                        string characteristics = "";
                        for (int i = 0; i < item.characteristics.Count; i++)
                            characteristics += item.characteristics[i] + i != item.characteristics.Count ? "," : "";
                        tblPaquetes.Rows.Add(item.id, characteristics);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
