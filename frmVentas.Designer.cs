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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.cmdRegistroVentas = new System.Windows.Forms.Button();
            this.txtMontoVentas = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaVentas = new System.Windows.Forms.MaskedTextBox();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lstVendedor = new System.Windows.Forms.ComboBox();
            this.lstCliente = new System.Windows.Forms.ComboBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lblTipoDeFactura = new System.Windows.Forms.Label();
            this.lblNumeroDeFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.MaskedTextBox();
            this.lstTipoFactura = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdRegistroVentas
            // 
            this.cmdRegistroVentas.Location = new System.Drawing.Point(309, 91);
            this.cmdRegistroVentas.Name = "cmdRegistroVentas";
            this.cmdRegistroVentas.Size = new System.Drawing.Size(63, 23);
            this.cmdRegistroVentas.TabIndex = 19;
            this.cmdRegistroVentas.Text = "Registrar";
            this.cmdRegistroVentas.UseVisualStyleBackColor = true;
            this.cmdRegistroVentas.Click += new System.EventHandler(this.cmdRegistroVentas_Click);
            // 
            // txtMontoVentas
            // 
            this.txtMontoVentas.Location = new System.Drawing.Point(71, 39);
            this.txtMontoVentas.Mask = "999999999";
            this.txtMontoVentas.Name = "txtMontoVentas";
            this.txtMontoVentas.Size = new System.Drawing.Size(100, 20);
            this.txtMontoVentas.TabIndex = 16;
            this.txtMontoVentas.ValidatingType = typeof(int);
            // 
            // txtFechaVentas
            // 
            this.txtFechaVentas.Location = new System.Drawing.Point(71, 12);
            this.txtFechaVentas.Mask = "00/00/0000";
            this.txtFechaVentas.Name = "txtFechaVentas";
            this.txtFechaVentas.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVentas.TabIndex = 15;
            this.txtFechaVentas.ValidatingType = typeof(System.DateTime);
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(11, 96);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(56, 13);
            this.lblVendedorID.TabIndex = 14;
            this.lblVendedorID.Text = "Vendedor:";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(11, 69);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(42, 13);
            this.lblClienteID.TabIndex = 13;
            this.lblClienteID.Text = "Cliente:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(11, 42);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(11, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(201, 91);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(45, 23);
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lstVendedor
            // 
            this.lstVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.Location = new System.Drawing.Point(71, 93);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(100, 21);
            this.lstVendedor.TabIndex = 24;
            // 
            // lstCliente
            // 
            this.lstCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(71, 66);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(100, 21);
            this.lstCliente.TabIndex = 25;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(253, 91);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(49, 23);
            this.cmdBorrar.TabIndex = 26;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // lblTipoDeFactura
            // 
            this.lblTipoDeFactura.AutoSize = true;
            this.lblTipoDeFactura.Location = new System.Drawing.Point(189, 15);
            this.lblTipoDeFactura.Name = "lblTipoDeFactura";
            this.lblTipoDeFactura.Size = new System.Drawing.Size(79, 13);
            this.lblTipoDeFactura.TabIndex = 27;
            this.lblTipoDeFactura.Text = "Tipo de factura";
            // 
            // lblNumeroDeFactura
            // 
            this.lblNumeroDeFactura.AutoSize = true;
            this.lblNumeroDeFactura.Location = new System.Drawing.Point(189, 42);
            this.lblNumeroDeFactura.Name = "lblNumeroDeFactura";
            this.lblNumeroDeFactura.Size = new System.Drawing.Size(95, 13);
            this.lblNumeroDeFactura.TabIndex = 28;
            this.lblNumeroDeFactura.Text = "Numero de factura";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(290, 39);
            this.txtNumeroFactura.Mask = "99999";
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(82, 20);
            this.txtNumeroFactura.TabIndex = 29;
            this.txtNumeroFactura.ValidatingType = typeof(int);
            // 
            // lstTipoFactura
            // 
            this.lstTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipoFactura.FormattingEnabled = true;
            this.lstTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipoFactura.Location = new System.Drawing.Point(274, 12);
            this.lstTipoFactura.Name = "lstTipoFactura";
            this.lstTipoFactura.Size = new System.Drawing.Size(98, 21);
            this.lstTipoFactura.TabIndex = 30;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 127);
            this.Controls.Add(this.lstTipoFactura);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblNumeroDeFactura);
            this.Controls.Add(this.lblTipoDeFactura);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.lstVendedor);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdRegistroVentas);
            this.Controls.Add(this.txtMontoVentas);
            this.Controls.Add(this.txtFechaVentas);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
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
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.ComboBox lstVendedor;
        private System.Windows.Forms.ComboBox lstCliente;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Label lblTipoDeFactura;
        private System.Windows.Forms.Label lblNumeroDeFactura;
        private System.Windows.Forms.MaskedTextBox txtNumeroFactura;
        private System.Windows.Forms.ComboBox lstTipoFactura;
    }
}