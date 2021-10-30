using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FB.Controladores;

namespace FB
{
    public partial class frmRegistroMoto : Form
    {

        public frmRegistroMoto()
        {
            InitializeComponent();
            cmbColor.Items.Add("Rojo");
            cmbColor.Items.Add("Azul");
            cmbColor.Items.Add("Violeta");
            cmbColor.Items.Add("Verde");
            cmbColor.Items.Add("Amarillo");
            cmbColor.Items.Add("Marron");
            cmbColor.Items.Add("Turquesa");
            cmbColor.Items.Add("Celeste");
            cmbColor.Items.Add("Naranja");
            cmbColor.Items.Add("Blanco");
            cmbColor.Items.Add("Negro");
            cmbColor.Items.Add("Beige");
            cmbColor.Items.Add("Gris");
            cmbColor.Items.Add("Rosa");
            cmbColor.Items.Add("Cian");
            cmbColor.Items.Add("Magenta");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                clsControladorMotos moto = new clsControladorMotos(txtPlaca.Text, txtMarca.Text, txtModelo.Text, txtLinea.Text, cmbColor.Text, Convert.ToInt32(txtCilindraje.Text),txtChasis.Text, txtMotor.Text);
                if (moto.ejecutarIngresarDetallesMoto())
                {
                    MessageBox.Show("Ingreso Exito");
                    frmRegistroPapelesMoto formularioPapeles = new frmRegistroPapelesMoto(txtPlaca.Text); ;
                    this.Hide();
                    formularioPapeles.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo algún problema");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void frmRegistroMoto_Load(object sender, EventArgs e)
        {

        }
    }
}
