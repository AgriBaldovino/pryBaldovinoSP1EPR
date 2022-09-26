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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void cmdLimpiar3_Click(object sender, EventArgs e)
        {
            dgvConsultaVentas.Rows.Clear();
        }
        private void cmdMostrar3_Click(object sender, EventArgs e)
        {
            StreamReader Ventas = new StreamReader("./Ventas.csv");
            while (!Ventas.EndOfStream)
            {
                string DatosVentas = Ventas.ReadLine();
                string[] vecDatosVentas = DatosVentas.Split(';');
                dgvConsultaVentas.Rows.Add(vecDatosVentas[0], vecDatosVentas[1], vecDatosVentas[2], vecDatosVentas[3], vecDatosVentas[4], vecDatosVentas[5]);
            }
            Ventas.Close();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
