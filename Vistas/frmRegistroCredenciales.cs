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

namespace FB.Vistas
{
    public partial class frmRegistroCredenciales : Form
    {
        private int Documento;
        public frmRegistroCredenciales(int numDocumento)
        {
            this.Documento = numDocumento;
            InitializeComponent();
        }

        private void btnSigueinte_Click(object sender, EventArgs e)
        {
            clsControladorUsuarios credencialesUsuario = new clsControladorUsuarios(
                Documento,
                txtEmail.Text,
                txtPassword.Text,
                txtCelular.Text
                );

            if (credencialesUsuario.ejecutarRegistrarCredenciales())
            {
                frmCambiarUbicacion ubicacion = new frmCambiarUbicacion(true);
                ubicacion.Show();
                this.Hide();
            }
        }
    }
}
