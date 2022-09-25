namespace pryBaldovinoSP1EPR
{
    partial class frmVentas
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
            this.cmdRegistroVentas = new System.Windows.Forms.Button();
            this.txtMontoVentas = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaVentas = new System.Windows.Forms.MaskedTextBox();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRegistroVentas
            // 
            this.cmdRegistroVentas.Location = new System.Drawing.Point(96, 130);
            this.cmdRegistroVentas.Name = "cmdRegistroVentas";
            this.cmdRegistroVentas.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistroVentas.TabIndex = 19;
            this.cmdRegistroVentas.Text = "Registrar";
            this.cmdRegistroVentas.UseVisualStyleBackColor = true;
            this.cmdRegistroVentas.Click += new System.EventHandler(this.cmdRegistroVentas_Click);
            // 
            // txtMontoVentas
            // 
            this.txtMontoVentas.Location = new System.Drawing.Point(75, 39);
            this.txtMontoVentas.Mask = "999999999";
            this.txtMontoVentas.Name = "txtMontoVentas";
            this.txtMontoVentas.Size = new System.Drawing.Size(100, 20);
            this.txtMontoVentas.TabIndex = 16;
            this.txtMontoVentas.ValidatingType = typeof(int);
            // 
            // txtFechaVentas
            // 
            this.txtFechaVentas.Location = new System.Drawing.Point(75, 12);
            this.txtFechaVentas.Mask = "00/00/0000";
            this.txtFechaVentas.Name = "txtFechaVentas";
            this.txtFechaVentas.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVentas.TabIndex = 15;
            this.txtFechaVentas.ValidatingType = typeof(System.DateTime);
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(15, 96);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(56, 13);
            this.lblVendedorID.TabIndex = 14;
            this.lblVendedorID.Text = "Vendedor:";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(15, 69);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(42, 13);
            this.lblClienteID.TabIndex = 13;
            this.lblClienteID.Text = "Cliente:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(15, 42);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(75, 66);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 21;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(75, 93);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 22;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(12, 130);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 161);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.cmdRegistroVentas);
            this.Controls.Add(this.txtMontoVentas);
            this.Controls.Add(this.txtFechaVentas);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdRegistroVentas;
        private System.Windows.Forms.MaskedTextBox txtMontoVentas;
        private System.Windows.Forms.MaskedTextBox txtFechaVentas;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Button cmdSalir;
    }
}