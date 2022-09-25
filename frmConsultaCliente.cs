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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultaClientes.Rows.Clear();
        }

        private void dgvConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            StreamReader Cliente = new StreamReader("./Cliente.csv");
            while (!Cliente.EndOfStream)
            {
                string DatoCliente = Cliente.ReadLine();
                string[] vecDatosCliente = DatoCliente.Split(';');
                dgvConsultaClientes.Rows.Add(vecDatosCliente[0], vecDatosCliente[1]);
            }
            Cliente.Close();
        }
    }
}
