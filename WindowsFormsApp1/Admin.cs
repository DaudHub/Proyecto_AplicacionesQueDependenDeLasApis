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
        }

        private async void Admin_Load(object sender, EventArgs e)
        {
            if (!await ObtainToken(username, password))
            {
                this.Hide();
                Login.login.Show();
                this.Dispose();
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
                    else Program.token = responseBody.token;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        
    }
}
