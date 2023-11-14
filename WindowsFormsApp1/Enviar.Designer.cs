namespace WindowsFormsApp1
{
    partial class Enviar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxLote = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCargar = new System.Windows.Forms.Panel();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAnio = new System.Windows.Forms.ComboBox();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCargar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxLote
            // 
            this.cbxLote.AccessibleDescription = "";
            this.cbxLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLote.FormattingEnabled = true;
            this.cbxLote.Location = new System.Drawing.Point(252, 138);
            this.cbxLote.Name = "cbxLote";
            this.cbxLote.Size = new System.Drawing.Size(143, 21);
            this.cbxLote.TabIndex = 48;
            this.cbxLote.DropDown += new System.EventHandler(this.cbxLote_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fecha estimada:";
            // 
            // pnlCargar
            // 
            this.pnlCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCargar.Controls.Add(this.lblEnviar);
            this.pnlCargar.Location = new System.Drawing.Point(251, 289);
            this.pnlCargar.Name = "pnlCargar";
            this.pnlCargar.Size = new System.Drawing.Size(98, 22);
            this.pnlCargar.TabIndex = 43;
            this.pnlCargar.Click += new System.EventHandler(this.pnlEnviar_Click);
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.ForeColor = System.Drawing.Color.White;
            this.lblEnviar.Location = new System.Drawing.Point(27, 2);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(45, 17);
            this.lblEnviar.TabIndex = 12;
            this.lblEnviar.Text = "Enviar";
            this.lblEnviar.Click += new System.EventHandler(this.lblEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID Lote:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Enviar Lote";
            // 
            // cbxDestino
            // 
            this.cbxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(255, 168);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(140, 21);
            this.cbxDestino.TabIndex = 50;
            this.cbxDestino.DropDown += new System.EventHandler(this.cbxDestino_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Destino:";
            // 
            // cbxAnio
            // 
            this.cbxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnio.FormattingEnabled = true;
            this.cbxAnio.Location = new System.Drawing.Point(201, 219);
            this.cbxAnio.Name = "cbxAnio";
            this.cbxAnio.Size = new System.Drawing.Size(61, 21);
            this.cbxAnio.TabIndex = 51;
            // 
            // cbxMes
            // 
            this.cbxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Location = new System.Drawing.Point(268, 219);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(62, 21);
            this.cbxMes.TabIndex = 52;
            // 
            // cbxDia
            // 
            this.cbxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Location = new System.Drawing.Point(336, 219);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(59, 21);
            this.cbxDia.TabIndex = 53;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(311, 252);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(84, 21);
            this.cbxEstado.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Estado en tránsito:";
            // 
            // Enviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxDia);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.cbxAnio);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxLote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlCargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Enviar";
            this.Size = new System.Drawing.Size(612, 415);
            this.pnlCargar.ResumeLayout(false);
            this.pnlCargar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCargar;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxAnio;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label5;
    }
}
