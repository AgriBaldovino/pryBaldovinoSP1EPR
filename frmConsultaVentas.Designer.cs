namespace pryBaldovinoSP1EPR
{
    partial class frmConsultaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVentas));
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.cmdLimpiar3 = new System.Windows.Forms.Button();
            this.cmdMostrar3 = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvConsultaVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.Size = new System.Drawing.Size(641, 150);
            this.dgvConsultaVentas.TabIndex = 0;
            // 
            // cmdLimpiar3
            // 
            this.cmdLimpiar3.Location = new System.Drawing.Point(497, 173);
            this.cmdLimpiar3.Name = "cmdLimpiar3";
            this.cmdLimpiar3.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar3.TabIndex = 28;
            this.cmdLimpiar3.Text = "Limpiar";
            this.cmdLimpiar3.UseVisualStyleBackColor = true;
            this.cmdLimpiar3.Click += new System.EventHandler(this.cmdLimpiar3_Click);
            // 
            // cmdMostrar3
            // 
            this.cmdMostrar3.Location = new System.Drawing.Point(578, 173);
            this.cmdMostrar3.Name = "cmdMostrar3";
            this.cmdMostrar3.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar3.TabIndex = 26;
            this.cmdMostrar3.Text = "Mostrar";
            this.cmdMostrar3.UseVisualStyleBackColor = true;
            this.cmdMostrar3.Click += new System.EventHandler(this.cmdMostrar3_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(416, 173);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 29;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Numero de factura";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo de factura";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vendedor";
            this.Column4.Name = "Column4";
            // 
            // frmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 200);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdLimpiar3);
            this.Controls.Add(this.cmdMostrar3);
            this.Controls.Add(this.dgvConsultaVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaVentas";
            this.Text = "Consulta ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaVentas;
        private System.Windows.Forms.Button cmdLimpiar3;
        private System.Windows.Forms.Button cmdMostrar3;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}