using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Cargar : UserControl
    {
        string username;
        string password;

        public Cargar(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
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
                    cbxLote.Items.Clear();
                    foreach (var item in responseBody.bundles)
                    {
                        cbxLote.Items.Add(item.bundleID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void pnlCargar_Click(object sender, EventArgs e)
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
                            Bundle = int.Parse(cbxLote.SelectedItem.ToString()),
                            Plate = txtMatricula.Text,
                            User = txtConductor.Text
                        }
                    };
                    MessageBox.Show(bodyContent.ToString());
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5173/loadbundle", content);
                    MessageBox.Show(response.ToString());
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al cargar lote: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al cargar lote: {responseBody.message} {responseBody.exception}");
                    MessageBox.Show("lote cargado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblCargar_Click(object sender, EventArgs e)
        {
            pnlCargar_Click(pnlCargar, e);
        }

    }
}
