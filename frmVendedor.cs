using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBaldovinoSP1EPR
{
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void cmdRegistrar2_Click(object sender, EventArgs e)
        {
            StreamWriter Vendedor = new StreamWriter("./Vendedor.csv", true);
            Vendedor.WriteLine(txtIdentificacion2.Text + ";" + txtNombre2.Text);
            MessageBox.Show("Archivo creado con éxito.");
            Vendedor.Close();
            txtIdentificacion2.Text = "";
            txtNombre2.Text = "";
            txtIdentificacion2.Focus();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
