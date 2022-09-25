namespace pryBaldovinoSP1EPR
{
    partial class FrmVendedor
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
            this.cmdRegistrar2 = new System.Windows.Forms.Button();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtIdentificacion2 = new System.Windows.Forms.TextBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblIdentificacion2 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRegistrar2
            // 
            this.cmdRegistrar2.Location = new System.Drawing.Point(130, 85);
            this.cmdRegistrar2.Name = "cmdRegistrar2";
            this.cmdRegistrar2.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar2.TabIndex = 10;
            this.cmdRegistrar2.Text = "Registrar";
            this.cmdRegistrar2.UseVisualStyleBackColor = true;
            this.cmdRegistrar2.Click += new System.EventHandler(this.cmdRegistrar2_Click);
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(64, 44);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(141, 20);
            this.txtNombre2.TabIndex = 9;
            // 
            // txtIdentificacion2
            // 
            this.txtIdentificacion2.Location = new System.Drawing.Point(90, 15);
            this.txtIdentificacion2.Name = "txtIdentificacion2";
            this.txtIdentificacion2.Size = new System.Drawing.Size(115, 20);
            this.txtIdentificacion2.TabIndex = 8;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(14, 47);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(44, 13);
            this.lblNombre2.TabIndex = 7;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblIdentificacion2
            // 
            this.lblIdentificacion2.AutoSize = true;
            this.lblIdentificacion2.Location = new System.Drawing.Point(14, 19);
            this.lblIdentificacion2.Name = "lblIdentificacion2";
            this.lblIdentificacion2.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion2.TabIndex = 6;
            this.lblIdentificacion2.Text = "Identificación";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(17, 85);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 11;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 117);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdRegistrar2);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtIdentificacion2);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblIdentificacion2);
            this.Name = "FrmVendedor";
            this.Text = "Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdRegistrar2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtIdentificacion2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblIdentificacion2;
        private System.Windows.Forms.Button cmdSalir;
    }
}