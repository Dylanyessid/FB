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
using FB.Modelo;
using FB.Vistas;

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
            clsControladorSolicitud solicitud = new clsControladorSolicitud(clsSesion.SolicitudActual, Convert.ToInt32(txtId.Text));
            solicitud.ejecutarAceptarConductorSolicitud();
            frmViajes formViaje = new frmViajes(recogida, destino, Convert.ToDecimal(txtPropuestaPrecio.Text), false);
            formViaje.ShowDialog();
            this.Close();

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
                
            }
        }

        private void frmConductoresDisponibles_Load(object sender, EventArgs e)
        {

            btnCancelar.Visible = false;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsControladorSolicitud controladorSolicitud = new clsControladorSolicitud();
            if (controladorSolicitud.ejecutarCancelarSolicitud())
            {
                MessageBox.Show("Solicitud Cancelada con éxito");
                btnCancelar.Visible = false;

                txtPropuestaPrecio.Enabled = true;
                btnBuscarConductores.Enabled = true;
            }

            
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {

            clsControladorConductores controladorConductores = new clsControladorConductores(clsSesion.SolicitudActual);
            dtgConductores.DataSource = controladorConductores.ejecutarConductoresSolicitud();
;
        }

        private void dtgConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgConductores.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
