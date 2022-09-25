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
    public partial class frmConsultaVendedor : Form
    {
        public frmConsultaVendedor()
        {
            InitializeComponent();
        }

        private void cmdLimpiar2_Click(object sender, EventArgs e)
        {
            dgvConsultaVendedor.Rows.Clear();
        }

        private void cmdMostrar2_Click(object sender, EventArgs e)
        {
            StreamReader Vendedor = new StreamReader("./Vendedor.csv");
            while (!Vendedor.EndOfStream)
            {
                string DatosVendedor = Vendedor.ReadLine();
                string[] vecDatosVendedor = DatosVendedor.Split(';');
                dgvConsultaVendedor.Rows.Add(vecDatosVendedor[0], vecDatosVendedor[1]);
            }
            Vendedor.Close();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
