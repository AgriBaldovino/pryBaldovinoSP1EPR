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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            bool repetido = false;
            if (File.Exists("./Cliente.csv"))
            {
                StreamReader ControlarRepCliente = new StreamReader("./Cliente.csv");
                while (!ControlarRepCliente.EndOfStream)
                {
                    string repiteCliente = ControlarRepCliente.ReadLine();
                    string[] Vendedor = repiteCliente.Split(';');
                    if (txtIdentificacion.Text == Vendedor[0])
                    {
                        MessageBox.Show("ID repetido, vuelva a intentar");
                        txtIdentificacion.Text = "";
                        txtIdentificacion.Focus();
                        repetido = true;
                    }
                }
                ControlarRepCliente.Close();

                if (repetido == false)
                {
                    StreamWriter Cliente = new StreamWriter("./Cliente.csv", true); //CSV excel
                                                                                    //TRUE ES PARA QUE NO SE SOBREESCRIBA
                    Cliente.WriteLine(txtIdentificacion.Text + ";" + txtNombre.Text); //WRITELINE escribe todo o que le indicamos en
                                                                                      //un renglon y luego hace salto de linea
                    MessageBox.Show("Datos cargados con éxito.");
                    Cliente.Close();
                    txtIdentificacion.Text = "";
                    txtNombre.Text = "";
                    txtIdentificacion.Focus();
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Cultivos.csv");
            MessageBox.Show("Usted borró el archivo");
        }
    }
}
