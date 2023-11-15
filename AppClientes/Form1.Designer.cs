namespace AppClientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcbxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblLotes = new System.Windows.Forms.DataGridView();
            this.clmIdPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstadoTransito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdLote = new System.Windows.Forms.TextBox();
            this.pnlConfirmar = new System.Windows.Forms.Panel();
            this.lblConfirmar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCerrarSesion.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLotes)).BeginInit();
            this.pnlConfirmar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbxLogo
            // 
            this.pcbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbxLogo.Image")));
            this.pcbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pcbxLogo.Name = "pcbxLogo";
            this.pcbxLogo.Size = new System.Drawing.Size(132, 77);
            this.pcbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLogo.TabIndex = 0;
            this.pcbxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(648, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 35);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.pnlCerrarSesion);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pcbxLogo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 452);
            this.panel2.TabIndex = 48;
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCerrarSesion.Controls.Add(this.lblCerrarSesion);
            this.pnlCerrarSesion.Location = new System.Drawing.Point(40, 404);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Size = new System.Drawing.Size(84, 27);
            this.pnlCerrarSesion.TabIndex = 55;
            this.pnlCerrarSesion.Click += new System.EventHandler(this.pnlCerrarSesion_Click);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesion.Location = new System.Drawing.Point(8, 7);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(70, 13);
            this.lblCerrarSesion.TabIndex = 0;
            this.lblCerrarSesion.Text = "Cerrar Sesión";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Location = new System.Drawing.Point(3, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 26);
            this.panel3.TabIndex = 49;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(155, 26);
            this.lblNombre.TabIndex = 49;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // tblLotes
            // 
            this.tblLotes.AllowUserToAddRows = false;
            this.tblLotes.AllowUserToDeleteRows = false;
            this.tblLotes.AllowUserToResizeRows = false;
            this.tblLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdPaquete,
            this.clmEstadoTransito,
            this.clmLote,
            this.clmCamion,
            this.clmChofer,
            this.clmFechaEstimada});
            this.tblLotes.Location = new System.Drawing.Point(179, 50);
            this.tblLotes.Name = "tblLotes";
            this.tblLotes.Size = new System.Drawing.Size(643, 388);
            this.tblLotes.TabIndex = 49;
            // 
            // clmIdPaquete
            // 
            this.clmIdPaquete.HeaderText = "Id Paquete";
            this.clmIdPaquete.Name = "clmIdPaquete";
            // 
            // clmEstadoTransito
            // 
            this.clmEstadoTransito.HeaderText = "Estado en Transito";
            this.clmEstadoTransito.Name = "clmEstadoTransito";
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            // 
            // clmCamion
            // 
            this.clmCamion.HeaderText = "Camion";
            this.clmCamion.Name = "clmCamion";
            // 
            // clmChofer
            // 
            this.clmChofer.HeaderText = "Chofer";
            this.clmChofer.Name = "clmChofer";
            // 
            // clmFechaEstimada
            // 
            this.clmFechaEstimada.HeaderText = "Fecha Estimada";
            this.clmFechaEstimada.Name = "clmFechaEstimada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(866, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Búsqueda Individual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(849, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Id - Paquete";
            // 
            // txtIdLote
            // 
            this.txtIdLote.Location = new System.Drawing.Point(951, 218);
            this.txtIdLote.Name = "txtIdLote";
            this.txtIdLote.Size = new System.Drawing.Size(86, 20);
            this.txtIdLote.TabIndex = 52;
            this.txtIdLote.TextChanged += new System.EventHandler(this.txtIdLote_TextChanged);
            // 
            // pnlConfirmar
            // 
            this.pnlConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlConfirmar.Controls.Add(this.lblConfirmar);
            this.pnlConfirmar.Location = new System.Drawing.Point(916, 254);
            this.pnlConfirmar.Name = "pnlConfirmar";
            this.pnlConfirmar.Size = new System.Drawing.Size(55, 27);
            this.pnlConfirmar.TabIndex = 53;
            this.pnlConfirmar.Click += new System.EventHandler(this.pnlConfirmar_Click);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.ForeColor = System.Drawing.Color.White;
            this.lblConfirmar.Location = new System.Drawing.Point(8, 7);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(40, 13);
            this.lblConfirmar.TabIndex = 0;
            this.lblConfirmar.Text = "Buscar";
            this.lblConfirmar.Click += new System.EventHandler(this.lblConfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.pnlConfirmar);
            this.Controls.Add(this.txtIdLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblLotes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCerrarSesion.ResumeLayout(false);
            this.pnlCerrarSesion.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblLotes)).EndInit();
            this.pnlConfirmar.ResumeLayout(false);
            this.pnlConfirmar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView tblLotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdLote;
        private System.Windows.Forms.Panel pnlConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstadoTransito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaEstimada;
    }
}

