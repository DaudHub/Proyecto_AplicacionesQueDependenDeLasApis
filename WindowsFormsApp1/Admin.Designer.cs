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
            this.pcbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.tblLotes = new System.Windows.Forms.DataGridView();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.cbxLote = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotes)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbxLogo
            // 
            this.pcbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbxLogo.Image")));
            this.pcbxLogo.Location = new System.Drawing.Point(12, 5);
            this.pcbxLogo.Name = "pcbxLogo";
            this.pcbxLogo.Size = new System.Drawing.Size(44, 26);
            this.pcbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLogo.TabIndex = 0;
            this.pcbxLogo.TabStop = false;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.cbxLote);
            this.pnlBackground.Controls.Add(this.lblLote);
            this.pnlBackground.Controls.Add(this.tblLotes);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBackground.Location = new System.Drawing.Point(0, 35);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(800, 415);
            this.pnlBackground.TabIndex = 2;
            // 
            // tblLotes
            // 
            this.tblLotes.AllowUserToAddRows = false;
            this.tblLotes.AllowUserToDeleteRows = false;
            this.tblLotes.AllowUserToResizeRows = false;
            this.tblLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLote,
            this.clmDestino,
            this.clmCalle,
            this.clmNumero});
            this.tblLotes.Location = new System.Drawing.Point(12, 15);
            this.tblLotes.Name = "tblLotes";
            this.tblLotes.Size = new System.Drawing.Size(319, 388);
            this.tblLotes.TabIndex = 38;
            // 
            // clmLote
            // 
            this.clmLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            // 
            // clmDestino
            // 
            this.clmDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDestino.HeaderText = "Destino";
            this.clmDestino.Name = "clmDestino";
            this.clmDestino.ReadOnly = true;
            // 
            // clmCalle
            // 
            this.clmCalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCalle.HeaderText = "Calle";
            this.clmCalle.Name = "clmCalle";
            this.clmCalle.ReadOnly = true;
            // 
            // clmNumero
            // 
            this.clmNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNumero.HeaderText = "Numero";
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.pcbxLogo);
            this.panel1.Controls.Add(this.pnlCerrarSesion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(270, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(423, 24);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "[usuario]";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCerrarSesion.Controls.Add(this.lblCerrarSesion);
            this.pnlCerrarSesion.Location = new System.Drawing.Point(699, 5);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camiones";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(370, 30);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(60, 25);
            this.lblLote.TabIndex = 39;
            this.lblLote.Text = "Lote:";
            // 
            // cbxLote
            // 
            this.cbxLote.FormattingEnabled = true;
            this.cbxLote.Location = new System.Drawing.Point(436, 34);
            this.cbxLote.Name = "cbxLote";
            this.cbxLote.Size = new System.Drawing.Size(121, 21);
            this.cbxLote.TabIndex = 40;
            this.cbxLote.DropDown += new System.EventHandler(this.cbxLote_DropDown);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCerrarSesion.ResumeLayout(false);
            this.pnlCerrarSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbxLogo;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.DataGridView tblLotes;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.ComboBox cbxLote;
        private System.Windows.Forms.Label lblLote;
    }
}