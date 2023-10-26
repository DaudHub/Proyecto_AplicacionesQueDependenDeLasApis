using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        public static Login login;


        public Login()
        {
            InitializeComponent();
            login = this;
        }

        private async void pnlINiciar_Click(object sender, EventArgs e)
        {
            if (!await VerifyUser(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Error de verificación");
                return;
            }
            Hide();
            new Admin(txtUsuario.Text, txtContraseña.Text).Show();
            txtUsuario.Text = null;
            txtContraseña.Text = null;
        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            pnlINiciar_Click(sender, e);
        }

        private async Task<bool> VerifyUser(string username, string password)
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
                StringContent content = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5077/api/verify", content);
                if (((int)response.StatusCode).ToString()[0] != '2')
                {
                    MessageBox.Show(JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync()).ToString());
                    return false;
                }
                var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                if (responseBody.success == true)
                    return true;
                else return false;
            }
        }

    }


}
