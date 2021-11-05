using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FB.Modelo;
using FB.Controladores;

namespace FB.Vistas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            lblNombre.Text = $"{clsSesion.PrimerNombre} {clsSesion.PrimerApellido}";
        }

        private void btnOfrecerServicio_Click(object sender, EventArgs e)
        {
            clsControladorUsuarios usuario = new clsControladorUsuarios(clsSesion.DocumentoSesion);


            if (usuario.ejecutarVerificarConductor())
            {
                clsSesion.OfreciendoServicio = true;
                frmCambiarUbicacion ubicacion = new frmCambiarUbicacion(false);
                this.Hide();
                ubicacion.ShowDialog();
                this.Show();
            }
            else
            {
                frmRegistroMoto formRegistroMoto = new frmRegistroMoto();
                formRegistroMoto.ShowDialog();
            }
            

            


        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clsSesion.OfreciendoServicio = false;
            frmCambiarUbicacion ubicacion = new frmCambiarUbicacion(false);
            this.Hide();
            ubicacion.ShowDialog();
            this.Show();
        }
    }
}
