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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void cmdRegistroVentas_Click(object sender, EventArgs e)
        {
            StreamWriter Ventas = new StreamWriter("./Ventas.csv", true);
            Ventas.WriteLine(txtFechaVentas.Text + ";" + txtMontoVentas.Text + ";" + txtCliente.Text + ";" + txtVendedor.Text);
            MessageBox.Show("Archivo creado con éxito.");
            Ventas.Close();
            txtFechaVentas.Text = "";
            txtMontoVentas.Text = "";
            txtCliente.Text = "";
            txtVendedor.Text = "";
            txtFechaVentas.Focus();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
