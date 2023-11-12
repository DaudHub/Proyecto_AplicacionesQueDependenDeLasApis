namespace WindowsFormsApp1
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pnlLotes = new System.Windows.Forms.Panel();
            this.lblLotes = new System.Windows.Forms.Label();
            this.pnlEnviar = new System.Windows.Forms.Panel();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.pnlCargar = new System.Windows.Forms.Panel();
            this.lblCargar = new System.Windows.Forms.Label();
            this.pnlPaquetes = new System.Windows.Forms.Panel();
            this.lblPaquetes = new System.Windows.Forms.Label();
            this.pcbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlSesion = new System.Windows.Forms.Panel();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.pnlLotes.SuspendLayout();
            this.pnlEnviar.SuspendLayout();
            this.pnlCargar.SuspendLayout();
            this.pnlPaquetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).BeginInit();
            this.pnlSesion.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.SidePanel.Controls.Add(this.pnlLotes);
            this.SidePanel.Controls.Add(this.pnlEnviar);
            this.SidePanel.Controls.Add(this.pnlCargar);
            this.SidePanel.Controls.Add(this.pnlPaquetes);
            this.SidePanel.Controls.Add(this.pcbxLogo);
            this.SidePanel.Controls.Add(this.pnlSesion);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(188, 450);
            this.SidePanel.TabIndex = 1;
            // 
            // pnlLotes
            // 
            this.pnlLotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlLotes.Controls.Add(this.lblLotes);
            this.pnlLotes.Location = new System.Drawing.Point(14, 185);
            this.pnlLotes.Name = "pnlLotes";
            this.pnlLotes.Size = new System.Drawing.Size(159, 34);
            this.pnlLotes.TabIndex = 2;
            this.pnlLotes.Click += new System.EventHandler(this.SidePanelButtonClicked);
            // 
            // lblLotes
            // 
            this.lblLotes.AutoSize = true;
            this.lblLotes.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotes.ForeColor = System.Drawing.Color.White;
            this.lblLotes.Location = new System.Drawing.Point(50, 3);
            this.lblLotes.Name = "lblLotes";
            this.lblLotes.Size = new System.Drawing.Size(62, 27);
            this.lblLotes.TabIndex = 2;
            this.lblLotes.Text = "Lotes";
            this.lblLotes.Click += new System.EventHandler(this.SidePanelButtonLabelClicked);
            // 
            // pnlEnviar
            // 
            this.pnlEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlEnviar.Controls.Add(this.lblEnviar);
            this.pnlEnviar.Location = new System.Drawing.Point(14, 282);
            this.pnlEnviar.Name = "pnlEnviar";
            this.pnlEnviar.Size = new System.Drawing.Size(159, 34);
            this.pnlEnviar.TabIndex = 3;
            this.pnlEnviar.Click += new System.EventHandler(this.SidePanelButtonClicked);
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.ForeColor = System.Drawing.Color.White;
            this.lblEnviar.Location = new System.Drawing.Point(45, 4);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(72, 27);
            this.lblEnviar.TabIndex = 3;
            this.lblEnviar.Text = "Enviar";
            this.lblEnviar.Click += new System.EventHandler(this.SidePanelButtonLabelClicked);
            // 
            // pnlCargar
            // 
            this.pnlCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCargar.Controls.Add(this.lblCargar);
            this.pnlCargar.Location = new System.Drawing.Point(14, 234);
            this.pnlCargar.Name = "pnlCargar";
            this.pnlCargar.Size = new System.Drawing.Size(159, 34);
            this.pnlCargar.TabIndex = 2;
            this.pnlCargar.Click += new System.EventHandler(this.SidePanelButtonClicked);
            // 
            // lblCargar
            // 
            this.lblCargar.AutoSize = true;
            this.lblCargar.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargar.ForeColor = System.Drawing.Color.White;
            this.lblCargar.Location = new System.Drawing.Point(44, 3);
            this.lblCargar.Name = "lblCargar";
            this.lblCargar.Size = new System.Drawing.Size(73, 27);
            this.lblCargar.TabIndex = 3;
            this.lblCargar.Text = "Cargar";
            this.lblCargar.Click += new System.EventHandler(this.SidePanelButtonLabelClicked);
            // 
            // pnlPaquetes
            // 
            this.pnlPaquetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlPaquetes.Controls.Add(this.lblPaquetes);
            this.pnlPaquetes.Location = new System.Drawing.Point(14, 137);
            this.pnlPaquetes.Name = "pnlPaquetes";
            this.pnlPaquetes.Size = new System.Drawing.Size(159, 34);
            this.pnlPaquetes.TabIndex = 1;
            this.pnlPaquetes.Click += new System.EventHandler(this.SidePanelButtonClicked);
            // 
            // lblPaquetes
            // 
            this.lblPaquetes.AutoSize = true;
            this.lblPaquetes.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaquetes.ForeColor = System.Drawing.Color.White;
            this.lblPaquetes.Location = new System.Drawing.Point(31, 4);
            this.lblPaquetes.Name = "lblPaquetes";
            this.lblPaquetes.Size = new System.Drawing.Size(98, 27);
            this.lblPaquetes.TabIndex = 1;
            this.lblPaquetes.Text = "Paquetes";
            this.lblPaquetes.Click += new System.EventHandler(this.SidePanelButtonLabelClicked);
            // 
            // pcbxLogo
            // 
            this.pcbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbxLogo.Image")));
            this.pcbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pcbxLogo.Name = "pcbxLogo";
            this.pcbxLogo.Size = new System.Drawing.Size(159, 92);
            this.pcbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLogo.TabIndex = 0;
            this.pcbxLogo.TabStop = false;
            // 
            // pnlSesion
            // 
            this.pnlSesion.Controls.Add(this.pnlCerrarSesion);
            this.pnlSesion.Location = new System.Drawing.Point(14, 371);
            this.pnlSesion.Name = "pnlSesion";
            this.pnlSesion.Size = new System.Drawing.Size(159, 72);
            this.pnlSesion.TabIndex = 0;
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCerrarSesion.Controls.Add(this.lblCerrarSesion);
            this.pnlCerrarSesion.Location = new System.Drawing.Point(35, 43);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Size = new System.Drawing.Size(89, 24);
            this.pnlCerrarSesion.TabIndex = 5;
            this.pnlCerrarSesion.Click += new System.EventHandler(this.pnlCerrarSesion_Click);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesion.Location = new System.Drawing.Point(10, 6);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(70, 13);
            this.lblCerrarSesion.TabIndex = 0;
            this.lblCerrarSesion.Text = "Cerrar Sesión";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBackground.Location = new System.Drawing.Point(188, 35);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(612, 415);
            this.pnlBackground.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.SidePanel.ResumeLayout(false);
            this.pnlLotes.ResumeLayout(false);
            this.pnlLotes.PerformLayout();
            this.pnlEnviar.ResumeLayout(false);
            this.pnlEnviar.PerformLayout();
            this.pnlCargar.ResumeLayout(false);
            this.pnlCargar.PerformLayout();
            this.pnlPaquetes.ResumeLayout(false);
            this.pnlPaquetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).EndInit();
            this.pnlSesion.ResumeLayout(false);
            this.pnlCerrarSesion.ResumeLayout(false);
            this.pnlCerrarSesion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pcbxLogo;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPaquetes;
        private System.Windows.Forms.Panel pnlEnviar;
        private System.Windows.Forms.Panel pnlCargar;
        private System.Windows.Forms.Label lblLotes;
        private System.Windows.Forms.Label lblPaquetes;
        private System.Windows.Forms.Panel pnlLotes;
        private System.Windows.Forms.Label lblCargar;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Panel pnlSesion;
        private System.Windows.Forms.Label lblEnviar;
    }
}