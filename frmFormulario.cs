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
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente objVent1 = new frmCliente();
            objVent1.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente objVent1 = new frmConsultaCliente();
            objVent1.ShowDialog();
        }

        private void cargaDeDatosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmVendedor objVent1 = new FrmVendedor();
            objVent1.ShowDialog();
        }

        private void consultasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaVendedor objVent1 = new frmConsultaVendedor();
            objVent1.ShowDialog();
        }

        private void cargaDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVentas objVent1 = new frmVentas();
            objVent1.ShowDialog();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVentas objVent1 = new frmConsultaVentas();
            objVent1.ShowDialog();
        }
    }
}
