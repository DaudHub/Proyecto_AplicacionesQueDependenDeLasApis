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
    public partial class Enviar : UserControl
    {

        string username;
        string password;

        public Enviar(string username, string password)
        {
            InitializeComponent();
            Initialize();
            this.username = username;
            this.password = password;
        }

        private async void Initialize()
        {
            for (int i = int.Parse(DateTime.Now.ToString("yyyy")); i <= int.Parse(DateTime.Now.ToString("yyyy")) + 5; i++)
                cbxAnio.Items.Add(i);
            for (int i = 1; i <= 12; i++)
                cbxMes.Items.Add(i);
            cbxAnio.SelectedItem = cbxAnio.Items[0];
            cbxMes.SelectedItem = cbxMes.Items[0];
        }

        private void cbxDia_DropDown(object sender, EventArgs e)
        {
            cbxDia.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(int.Parse(DateTime.Now.ToString("yyyy")), (int) cbxMes.SelectedItem); i++)
                cbxDia.Items.Add(i);
        }

        private async void pnlEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var dictionary = new Dictionary<string, int>()
                    {
                        {"en depósito", 1},
                        {"en transito", 2}
                    };
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
                            BundleID = int.Parse(cbxLote.SelectedItem.ToString()),
                            Destination = int.Parse(cbxDestino.SelectedItem.ToString()),
                            EstimatedDate = $"{cbxAnio.SelectedItem.ToString()}-{cbxMes.SelectedItem.ToString()}-{cbxDia.SelectedItem.ToString()}",
                            StateID = dictionary[cbxEstado.SelectedItem.ToString()]
                        }
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5173/sendbundle", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al enviar lote: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al enviar lote: {responseBody.message} {responseBody.exception}");
                    MessageBox.Show("lote enviado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblEnviar_Click(object sender, EventArgs e)
        {
            pnlEnviar_Click(sender, e);
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

        private async void cbxDestino_DropDown(object sender, EventArgs e)
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
                    var response = await client.PostAsync("http://localhost:5173/places", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener lugares de envío: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener lugares de envío: {responseBody.message} {responseBody.exception}");
                    cbxDestino.Items.Clear();
                    foreach (var item in responseBody.places)
                    {
                        cbxDestino.Items.Add(item);
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
