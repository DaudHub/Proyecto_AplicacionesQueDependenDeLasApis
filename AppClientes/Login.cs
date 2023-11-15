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

namespace AppClientes
{

    public partial class Login : Form
    {
        private Panel panel2;
        private Panel pnlINiciar;
        private Label lblIniciar;
        private TextBox txtContraseña;
        private Label label3;
        private Label label2;
        private TextBox txtUsuario;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        public static Login login;


        public Login()
        {
            InitializeComponent();
            login = this;
        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            pnlIniciar_Click(sender, e);
        }

        private async Task<bool> VerifyUser(string username, string password)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var bodyContent = new
                    {
                        Username = txtUsuario.Text,
                        Password = txtContraseña.Text,
                        Name = "",
                        Surname = "",
                        Role = "4"
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
            catch (Exception ex)
            {
                return false;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlINiciar = new System.Windows.Forms.Panel();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.pnlINiciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pnlINiciar);
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(383, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 337);
            this.panel2.TabIndex = 4;
            // 
            // pnlINiciar
            // 
            this.pnlINiciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.pnlINiciar.Controls.Add(this.lblIniciar);
            this.pnlINiciar.Location = new System.Drawing.Point(89, 269);
            this.pnlINiciar.Name = "pnlINiciar";
            this.pnlINiciar.Size = new System.Drawing.Size(121, 32);
            this.pnlINiciar.TabIndex = 1;
            this.pnlINiciar.Click += new System.EventHandler(this.pnlIniciar_Click);
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciar.ForeColor = System.Drawing.Color.White;
            this.lblIniciar.Location = new System.Drawing.Point(29, 4);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(61, 24);
            this.lblIniciar.TabIndex = 5;
            this.lblIniciar.Text = "Iniciar";
            this.lblIniciar.Click += new System.EventHandler(this.lblIniciar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(147, 177);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(117, 126);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(151, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(105, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 180);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(784, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlINiciar.ResumeLayout(false);
            this.pnlINiciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private async void pnlIniciar_Click(object sender, EventArgs e)
        {
            if(await VerifyUser(txtUsuario.Text, txtContraseña.Text))
            {
                Form1 f1 = new Form1(txtUsuario.Text, txtContraseña.Text);
                f1.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Error de autenticacion");
            }

        }
    }

}