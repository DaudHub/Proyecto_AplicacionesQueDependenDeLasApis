using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        string username;
        string password;
        Paquetes paquetes;
        Lotes lotes;
        Cargar cargar;
        Enviar enviar;

        public Admin(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            paquetes = new Paquetes(username, password);
            lotes = new Lotes(username, password);
            cargar = new Cargar();
            enviar = new Enviar();
            UpdateButtons((Panel)SidePanel.Controls["pnlPaquetes"]);
        }

        private async void Admin_Load(object sender, EventArgs e)
        {
            if (!await ObtainToken(username, password))
            {
                Login.login.Show();
                this.Dispose();
                return;
            }
            pnlBackground.Controls.Add(paquetes);
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
                        Role = "2"
                    };
                    var body = JsonConvert.SerializeObject(bodyContent);
                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5077/api/gettoken", content);
                    if (((int)response.StatusCode).ToString()[0] != '2') throw new Exception("Error al obtener token: el servidor no responde correctamente");
                    var responseBody = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (responseBody.success == false) throw new Exception($"Error al obtener token: {responseBody.message}");
                    else Program.Token = responseBody.token;
                    MessageBox.Show(Program.Token);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void UpdateButtons(Panel pressed)
        {
            foreach (Control pnl in SidePanel.Controls)
            {
                if(pnl != pressed && pnl is Panel)
                    pnl.BackColor = SidePanel.BackColor;
                else pnl.BackColor = Color.FromArgb(49, 133, 185);
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

        private void SidePanelButtonClicked(object sender, EventArgs e)
        {
            UpdateButtons((Panel) sender);
            pnlBackground.Controls.Clear();
            if (sender.Equals(pnlPaquetes)) pnlBackground.Controls.Add(paquetes);
            else if (sender.Equals(pnlLotes)) pnlBackground.Controls.Add(lotes);
            else if (sender.Equals(pnlCargar)) pnlBackground.Controls.Add(cargar);
            else if (sender.Equals(pnlEnviar)) pnlBackground.Controls.Add(enviar);
        }

        private void SidePanelButtonLabelClicked(object sender, EventArgs e)
        {
            SidePanelButtonClicked(((Label)sender).Parent, e);
        }

        
    }
}
