namespace WindowsFormsApp1
{
    partial class Paquetes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblPaquetes = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCaracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstadoFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPaquetes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPaquetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmComentarios,
            this.clmCaracteristicas,
            this.clmPeso,
            this.clmVolumen,
            this.clmComprador,
            this.clmEstadoFisico});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPaquetes.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblPaquetes.Location = new System.Drawing.Point(16, 14);
            this.tblPaquetes.Name = "tblPaquetes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPaquetes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblPaquetes.Size = new System.Drawing.Size(444, 384);
            this.tblPaquetes.TabIndex = 36;
            // 
            // clmID
            // 
            this.clmID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmComentarios
            // 
            this.clmComentarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmComentarios.HeaderText = "Comentarios";
            this.clmComentarios.Name = "clmComentarios";
            this.clmComentarios.ReadOnly = true;
            // 
            // clmCaracteristicas
            // 
            this.clmCaracteristicas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCaracteristicas.HeaderText = "Caracteristicas";
            this.clmCaracteristicas.Name = "clmCaracteristicas";
            this.clmCaracteristicas.ReadOnly = true;
            // 
            // clmPeso
            // 
            this.clmPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPeso.HeaderText = "Peso (Kg)";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            // 
            // clmVolumen
            // 
            this.clmVolumen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmVolumen.HeaderText = "Volumen (m3)";
            this.clmVolumen.Name = "clmVolumen";
            this.clmVolumen.ReadOnly = true;
            // 
            // clmComprador
            // 
            this.clmComprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmComprador.HeaderText = "Comprador";
            this.clmComprador.Name = "clmComprador";
            this.clmComprador.ReadOnly = true;
            // 
            // clmEstadoFisico
            // 
            this.clmEstadoFisico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmEstadoFisico.HeaderText = "Estado Físico";
            this.clmEstadoFisico.Name = "clmEstadoFisico";
            this.clmEstadoFisico.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 59);
            this.label1.TabIndex = 37;
            this.label1.Text = "Búsqueda individual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(523, 230);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 20);
            this.txtID.TabIndex = 39;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // Paquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblPaquetes);
            this.Name = "Paquetes";
            this.Size = new System.Drawing.Size(612, 415);
            this.Load += new System.EventHandler(this.Paquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tblPaquetes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCaracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVolumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstadoFisico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
    }
}
