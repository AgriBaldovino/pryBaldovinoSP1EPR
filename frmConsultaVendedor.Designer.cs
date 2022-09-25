namespace pryBaldovinoSP1EPR
{
    partial class frmConsultaVendedor
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
            this.cmdLimpiar2 = new System.Windows.Forms.Button();
            this.cmdMostrar2 = new System.Windows.Forms.Button();
            this.dgvConsultaVendedor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLimpiar2
            // 
            this.cmdLimpiar2.Location = new System.Drawing.Point(94, 168);
            this.cmdLimpiar2.Name = "cmdLimpiar2";
            this.cmdLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar2.TabIndex = 6;
            this.cmdLimpiar2.Text = "Limpiar";
            this.cmdLimpiar2.UseVisualStyleBackColor = true;
            this.cmdLimpiar2.Click += new System.EventHandler(this.cmdLimpiar2_Click);
            // 
            // cmdMostrar2
            // 
            this.cmdMostrar2.Location = new System.Drawing.Point(176, 168);
            this.cmdMostrar2.Name = "cmdMostrar2";
            this.cmdMostrar2.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar2.TabIndex = 5;
            this.cmdMostrar2.Text = "Mostrar";
            this.cmdMostrar2.UseVisualStyleBackColor = true;
            this.cmdMostrar2.Click += new System.EventHandler(this.cmdMostrar2_Click);
            // 
            // dgvConsultaVendedor
            // 
            this.dgvConsultaVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsultaVendedor.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaVendedor.Name = "dgvConsultaVendedor";
            this.dgvConsultaVendedor.Size = new System.Drawing.Size(240, 150);
            this.dgvConsultaVendedor.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificacion";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(13, 168);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 7;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmConsultaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 197);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdLimpiar2);
            this.Controls.Add(this.cmdMostrar2);
            this.Controls.Add(this.dgvConsultaVendedor);
            this.Name = "frmConsultaVendedor";
            this.Text = "Consulta vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdLimpiar2;
        private System.Windows.Forms.Button cmdMostrar2;
        private System.Windows.Forms.DataGridView dgvConsultaVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button cmdSalir;
    }
}