using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Paquetes : UserControl
    {

        string username;
        string password;

        public Paquetes(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void Paquetes_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private async void UpdateTable()
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
                    var response = await client.PostAsync("http://localhost:5173/packages", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener paquete: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener paquete: {responseBody.message} {responseBody.exception}");
                    tblPaquetes.Rows.Clear();
                    foreach (var item in responseBody.packages)
                    {
                        string characteristics = "";
                        for (int i = 0; i < item.characteristics.Count; i++)
                            characteristics += item.characteristics[i] + (i != item.characteristics.Count - 1 ? "," : "");
                        tblPaquetes.Rows.Add(item.id, item.comments, characteristics, item.weight_Kg, item.volume_m3, item.user, item.physicalState);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                UpdateTable();
                return;
            }
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
                        Element = int.Parse(txtID.Text)
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5173/getpackage", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener paquete: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener paquete: {responseBody.message} {responseBody.exception}");
                    tblPaquetes.Rows.Clear();
                    string characteristics = "";
                    for (int i = 0; i < responseBody.package.characteristics.Count; i++)
                        characteristics += responseBody.package.characteristics[i].ToString() + (i != responseBody.package.characteristics.Count - 1 ? "," : "");
                    tblPaquetes.Rows.Add(responseBody.package.id, responseBody.package.comments, characteristics, responseBody.package.weight_Kg, responseBody.package.volume_m3, responseBody.package.user, responseBody.package.physicalState);
                    
                }
            }
            catch (Exception ex)
            {
                tblPaquetes.Rows.Clear();
            }
        }

        
    }
}
