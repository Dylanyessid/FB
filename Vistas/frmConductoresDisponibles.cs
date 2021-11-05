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
    public partial class frmConductoresDisponibles : Form
    {
        string recogida;
        string destino;
        public frmConductoresDisponibles(string recogida, string destino)
        {
            this.recogida = recogida;
            this.destino = destino;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarConductores_Click(object sender, EventArgs e)
        {
            clsControladorSolicitud solicitud = new clsControladorSolicitud(Convert.ToDecimal(txtPropuestaPrecio.Text),this.recogida, this.destino);
            if (solicitud.ejecutarCrearSolicitud())
            {
                txtPropuestaPrecio.Enabled = false;
                btnBuscarConductores.Enabled = false;
                MessageBox.Show("Solicitud creada con éxito!");

                btnCancelar.Visible = true;
                lblOpciones.Visible = true;
                cmbOpciones.Visible = true;
                lblPrimerNombre.Visible = true;
                lblPrimerApellido.Visible = true;
                lblPrecio.Visible = true;
                lblMarca.Visible = true;
                lblModelo.Visible = true;
                lblPlaca.Visible = true;
                lblColor.Visible = true;
            }
        }

        private void frmConductoresDisponibles_Load(object sender, EventArgs e)
        {

            btnCancelar.Visible = false;
            lblOpciones.Visible = false;
            cmbOpciones.Visible = false;
            lblPrimerNombre.Visible = false;
            lblPrimerApellido.Visible = false;
            lblPrecio.Visible = false;
            lblMarca.Visible = false;
            lblModelo.Visible = false;
            lblPlaca.Visible = false;
            lblColor.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsControladorSolicitud controladorSolicitud = new clsControladorSolicitud();
            if (controladorSolicitud.ejecutarCancelarSolicitud())
            {
                MessageBox.Show("Solicitud Cancelada con éxito");
                btnCancelar.Visible = false;
                lblOpciones.Visible = false;
                cmbOpciones.Visible = false;
                lblPrimerNombre.Visible = false;
                lblPrimerApellido.Visible = false;
                lblPrecio.Visible = false;
                lblMarca.Visible = false;
                lblModelo.Visible = false;
                lblPlaca.Visible = false;
                lblColor.Visible = false;

                txtPropuestaPrecio.Enabled = true;
                btnBuscarConductores.Enabled = true;
            }

            
        }
    }
}
