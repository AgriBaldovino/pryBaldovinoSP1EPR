namespace pryBaldovinoSP1EPR
{
    partial class frmFormulario
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cargaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeDatosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(252, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeDatosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeDatosToolStripMenuItem2,
            this.consultasToolStripMenuItem2});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cargaDeDatosToolStripMenuItem
            // 
            this.cargaDeDatosToolStripMenuItem.Name = "cargaDeDatosToolStripMenuItem";
            this.cargaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargaDeDatosToolStripMenuItem.Text = "Carga de datos";
            this.cargaDeDatosToolStripMenuItem.Click += new System.EventHandler(this.cargaDeDatosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeDatosToolStripMenuItem1,
            this.consultasToolStripMenuItem1});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // cargaDeDatosToolStripMenuItem1
            // 
            this.cargaDeDatosToolStripMenuItem1.Name = "cargaDeDatosToolStripMenuItem1";
            this.cargaDeDatosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cargaDeDatosToolStripMenuItem1.Text = "Carga de datos";
            this.cargaDeDatosToolStripMenuItem1.Click += new System.EventHandler(this.cargaDeDatosToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            this.consultasToolStripMenuItem1.Click += new System.EventHandler(this.consultasToolStripMenuItem1_Click);
            // 
            // cargaDeDatosToolStripMenuItem2
            // 
            this.cargaDeDatosToolStripMenuItem2.Name = "cargaDeDatosToolStripMenuItem2";
            this.cargaDeDatosToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cargaDeDatosToolStripMenuItem2.Text = "Carga de datos";
            this.cargaDeDatosToolStripMenuItem2.Click += new System.EventHandler(this.cargaDeDatosToolStripMenuItem2_Click);
            // 
            // consultasToolStripMenuItem2
            // 
            this.consultasToolStripMenuItem2.Name = "consultasToolStripMenuItem2";
            this.consultasToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.consultasToolStripMenuItem2.Text = "Consultas";
            this.consultasToolStripMenuItem2.Click += new System.EventHandler(this.consultasToolStripMenuItem2_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(165, 27);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 1;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 57);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFormulario";
            this.Text = "Formulario principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargaDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeDatosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.Button cmdSalir;
    }
}

