using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {

        Paquetes paquetes;
        Lotes lotes;
        Cargar cargar;
        Enviar enviar;

        public Admin(string name)
        {
            InitializeComponent();
            paquetes = new Paquetes();
            lotes = new Lotes();
            cargar = new Cargar();
            enviar = new Enviar();
            pnlBackground.Controls.Add(new Paquetes());
            UpdateButtons((Panel)SidePanel.Controls["pnlPaquetes"]);
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
        }

        private void SidePanelButtonLabelClicked(object sender, EventArgs e)
        {
            SidePanelButtonClicked(((Label)sender).Parent, e);
        }
    }
}
