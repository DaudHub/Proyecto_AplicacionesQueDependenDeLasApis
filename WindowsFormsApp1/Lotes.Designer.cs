namespace WindowsFormsApp1
{
    partial class Lotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCrearLote = new System.Windows.Forms.Panel();
            this.lblCrearLote = new System.Windows.Forms.Label();
            this.txtIdLote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAgregarPaquete = new System.Windows.Forms.Panel();
            this.lblAgregarPaquete = new System.Windows.Forms.Label();
            this.txtIdLoteAgregar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdAgregarPaquete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblPaquetes = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCaracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxIdLote = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCrearLote.SuspendLayout();
            this.pnlAgregarPaquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCrearLote
            // 
            this.pnlCrearLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlCrearLote.Controls.Add(this.lblCrearLote);
            this.pnlCrearLote.Location = new System.Drawing.Point(90, 136);
            this.pnlCrearLote.Name = "pnlCrearLote";
            this.pnlCrearLote.Size = new System.Drawing.Size(98, 22);
            this.pnlCrearLote.TabIndex = 23;
            this.pnlCrearLote.Click += new System.EventHandler(this.pnlCrearLote_Click);
            // 
            // lblCrearLote
            // 
            this.lblCrearLote.AutoSize = true;
            this.lblCrearLote.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearLote.ForeColor = System.Drawing.Color.White;
            this.lblCrearLote.Location = new System.Drawing.Point(28, 2);
            this.lblCrearLote.Name = "lblCrearLote";
            this.lblCrearLote.Size = new System.Drawing.Size(40, 17);
            this.lblCrearLote.TabIndex = 12;
            this.lblCrearLote.Text = "Crear";
            this.lblCrearLote.Click += new System.EventHandler(this.lblCrear_Click);
            // 
            // txtIdLote
            // 
            this.txtIdLote.Location = new System.Drawing.Point(100, 101);
            this.txtIdLote.Name = "txtIdLote";
            this.txtIdLote.Size = new System.Drawing.Size(98, 20);
            this.txtIdLote.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Crear Lote";
            // 
            // pnlAgregarPaquete
            // 
            this.pnlAgregarPaquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(133)))), ((int)(((byte)(185)))));
            this.pnlAgregarPaquete.Controls.Add(this.lblAgregarPaquete);
            this.pnlAgregarPaquete.Location = new System.Drawing.Point(90, 301);
            this.pnlAgregarPaquete.Name = "pnlAgregarPaquete";
            this.pnlAgregarPaquete.Size = new System.Drawing.Size(98, 22);
            this.pnlAgregarPaquete.TabIndex = 27;
            this.pnlAgregarPaquete.Click += new System.EventHandler(this.pnlAgregarPaquete_Click);
            // 
            // lblAgregarPaquete
            // 
            this.lblAgregarPaquete.AutoSize = true;
            this.lblAgregarPaquete.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarPaquete.ForeColor = System.Drawing.Color.White;
            this.lblAgregarPaquete.Location = new System.Drawing.Point(23, 2);
            this.lblAgregarPaquete.Name = "lblAgregarPaquete";
            this.lblAgregarPaquete.Size = new System.Drawing.Size(53, 17);
            this.lblAgregarPaquete.TabIndex = 12;
            this.lblAgregarPaquete.Text = "Agregar";
            this.lblAgregarPaquete.Click += new System.EventHandler(this.lblAgregarPaquete_Click);
            // 
            // txtIdLoteAgregar
            // 
            this.txtIdLoteAgregar.Location = new System.Drawing.Point(147, 240);
            this.txtIdLoteAgregar.Name = "txtIdLoteAgregar";
            this.txtIdLoteAgregar.Size = new System.Drawing.Size(70, 20);
            this.txtIdLoteAgregar.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID lote:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Agregar paquete";
            // 
            // txtIdAgregarPaquete
            // 
            this.txtIdAgregarPaquete.Location = new System.Drawing.Point(147, 270);
            this.txtIdAgregarPaquete.Name = "txtIdAgregarPaquete";
            this.txtIdAgregarPaquete.Size = new System.Drawing.Size(70, 20);
            this.txtIdAgregarPaquete.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID paquete:";
            // 
            // tblPaquetes
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tblPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPaquetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmCaracteristicas});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPaquetes.DefaultCellStyle = dataGridViewCellStyle11;
            this.tblPaquetes.Location = new System.Drawing.Point(281, 101);
            this.tblPaquetes.Name = "tblPaquetes";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPaquetes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.tblPaquetes.Size = new System.Drawing.Size(294, 275);
            this.tblPaquetes.TabIndex = 37;
            // 
            // clmID
            // 
            this.clmID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmCaracteristicas
            // 
            this.clmCaracteristicas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCaracteristicas.HeaderText = "Caracteristicas";
            this.clmCaracteristicas.Name = "clmCaracteristicas";
            this.clmCaracteristicas.ReadOnly = true;
            // 
            // cbxIdLote
            // 
            this.cbxIdLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdLote.FormattingEnabled = true;
            this.cbxIdLote.Location = new System.Drawing.Point(409, 45);
            this.cbxIdLote.Name = "cbxIdLote";
            this.cbxIdLote.Size = new System.Drawing.Size(121, 21);
            this.cbxIdLote.TabIndex = 39;
            this.cbxIdLote.DropDown += new System.EventHandler(this.IDLote_DropDown);
            this.cbxIdLote.SelectedValueChanged += new System.EventHandler(this.cbxIdLote_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "ID Lote:";
            // 
            // Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxIdLote);
            this.Controls.Add(this.tblPaquetes);
            this.Controls.Add(this.txtIdAgregarPaquete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlAgregarPaquete);
            this.Controls.Add(this.txtIdLoteAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlCrearLote);
            this.Controls.Add(this.txtIdLote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lotes";
            this.Size = new System.Drawing.Size(612, 415);
            this.pnlCrearLote.ResumeLayout(false);
            this.pnlCrearLote.PerformLayout();
            this.pnlAgregarPaquete.ResumeLayout(false);
            this.pnlAgregarPaquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCrearLote;
        private System.Windows.Forms.Label lblCrearLote;
        private System.Windows.Forms.TextBox txtIdLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAgregarPaquete;
        private System.Windows.Forms.Label lblAgregarPaquete;
        private System.Windows.Forms.TextBox txtIdLoteAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdAgregarPaquete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tblPaquetes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCaracteristicas;
        private System.Windows.Forms.ComboBox cbxIdLote;
        private System.Windows.Forms.Label label6;
    }
}
