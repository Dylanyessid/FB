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
using FB.Vistas;

namespace FB
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            
        }

        private void frmRegistrocs_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string sexo;
            if (rdoHombre.Checked)
            {
                sexo = rdoHombre.Text;
            }
            else
            {
                sexo = rdoMujer.Text;
            }
            

            clsControladorUsuarios controlador = new clsControladorUsuarios(
                txtDocumentoIdentidad.Text,
                txtPrimerNombre.Text,
                txtSegundoNombre.Text,
                txtPrimerApellido.Text,
                txtSegundoApellido.Text,
                dtpFechaNacimiento.Value,
                sexo,
                txtPais.Text,
                txtEstado.Text,
                txtCuidad.Text
                ) ;

            if (controlador.ejecutarRegistrarUsuario())
            {
                frmRegistroCredenciales credenciales = new frmRegistroCredenciales((txtDocumentoIdentidad.Text));
                credenciales.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
}
