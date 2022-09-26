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
            bool repetido = false;
            if (File.Exists("./Vendedor.csv"))
            {
                StreamReader ControlarRepVendedor = new StreamReader("./Vendedor.csv");
                while (!ControlarRepVendedor.EndOfStream)
                {
                    string repiteVendedor = ControlarRepVendedor.ReadLine();
                    string[] Vendedor = repiteVendedor.Split(';');
                    if (txtIdentificacion2.Text == Vendedor[0])
                    {
                        MessageBox.Show("ID repetido, vuelva a intentar");
                        txtIdentificacion2.Text = "";
                        txtIdentificacion2.Focus();
                        repetido = true;
                    }
                }
                ControlarRepVendedor.Close();

                if (repetido == false)
                {
                    StreamWriter Vendedor = new StreamWriter("./Vendedor.csv", true);
                    Vendedor.WriteLine(txtIdentificacion2.Text + ";" + txtNombre2.Text + ";" + lstActivo.SelectedItem + ";" + lstComision.SelectedItem);
                    MessageBox.Show("Datos cargados con éxito.");
                    Vendedor.Close();
                    txtIdentificacion2.Text = "";
                    txtNombre2.Text = "";
                    txtIdentificacion2.Focus();
                }
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Vendedor.csv");
            MessageBox.Show("Usted borró el archivo");
        }
    }
}
