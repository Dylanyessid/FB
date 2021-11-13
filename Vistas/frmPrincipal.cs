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
        private clsControladorMetodoPago metodoPago;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        void obtenerMetodosPago()
        {
            metodoPago = new clsControladorMetodoPago(clsSesion.DocumentoSesion);
            DataTable dtMetodosPago = metodoPago.ejecutarConsultarMetodosPago();
            if (dtMetodosPago.Rows.Count == 0)
            {
                lblAviso.Visible = true;
                cmbMetodosPago.Visible = false;
                btnEditarMetodoPago.Visible = false;
                btnEliminarMetodoPago.Visible = false;
            }
            else
            {
                lblAviso.Visible = false;
                foreach (DataRow metodoPago in dtMetodosPago.Rows)
                {
                    cmbMetodosPago.Items.Add("Tarjeta de: " + metodoPago["tipoTarjeta"] + "  ||  " + metodoPago["concepto"]);
                }
            }
            lblNombre.Text = $"{clsSesion.PrimerNombre} {clsSesion.PrimerApellido}";
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            obtenerMetodosPago();
           
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

        private void btnPedirServicio_Click(object sender, EventArgs e)
        {
            
            clsSesion.OfreciendoServicio = false;
            frmCambiarUbicacion ubicacion = new frmCambiarUbicacion(false);
            this.Hide();
            ubicacion.ShowDialog();
            this.Show();
            
        }

        private void btnAgregatMetodoPago_Click(object sender, EventArgs e)
        {
            frmMetodoPago formMetodoPago = new frmMetodoPago();
            this.Hide();
            formMetodoPago.ShowDialog();
            this.Controls.Clear();
            this.InitializeComponent();
            obtenerMetodosPago();
            this.Show();
;
            
        }
    }
}
