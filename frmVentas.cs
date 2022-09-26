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
            bool repetido = false;
            if (File.Exists("./Ventas.csv"))
            {
                StreamReader ControlarRepFactura = new StreamReader("./Ventas.csv");
                while (!ControlarRepFactura.EndOfStream)
                {
                    string repiteFactura = ControlarRepFactura.ReadLine();
                    string[] Factura = repiteFactura.Split(';');
                    if (txtNumeroFactura.Text == Factura[0])
                    {
                        MessageBox.Show("ID repetido, vuelva a intentar");
                        txtNumeroFactura.Text = "";
                        txtNumeroFactura.Focus();
                        repetido = true;
                    }
                }
                ControlarRepFactura.Close();

                if (repetido == false)
                {
                    StreamWriter Ventas = new StreamWriter("./Ventas.csv", true);
                    Ventas.WriteLine(txtNumeroFactura.Text + ";" + lstTipoFactura.SelectedItem + ";" + txtFechaVentas.Text + ";" + txtMontoVentas.Text + ";" + lstCliente.SelectedItem + ";" + lstVendedor.SelectedItem);
                    MessageBox.Show("Datos cargados con éxito.");
                    Ventas.Close();
                    txtFechaVentas.Text = "";
                    txtMontoVentas.Text = "";
                    lstCliente.SelectedIndex = -1;
                    lstVendedor.SelectedIndex = -1;
                    lstTipoFactura.SelectedIndex = -1;
                    txtNumeroFactura.Text = "";

                    txtFechaVentas.Focus();
                }
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamReader lectorVendedor = new StreamReader("./Vendedor.csv");
            char varSeparador = Convert.ToChar(";");

            while (!lectorVendedor.EndOfStream)
            {
                string[] Vendedor = lectorVendedor.ReadLine().Split(varSeparador);
                lstVendedor.Items.Add(Vendedor[0]);
            }

            lectorVendedor.Close();

            StreamReader lectorCliente = new StreamReader("./Cliente.csv");

            while (!lectorCliente.EndOfStream)
            {
                string[] Cliente = lectorCliente.ReadLine().Split(varSeparador);
                lstCliente.Items.Add(Cliente[0]);
            }

            lectorCliente.Close();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Ventas.csv");
            MessageBox.Show("Usted borró el archivo");
        }
    }
}
