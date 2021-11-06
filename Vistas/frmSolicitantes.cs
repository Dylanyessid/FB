using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FB.Controladores;

namespace FB.Vistas
{
    public partial class frmSolicitantes : Form
    {
        DataTable info;
        public frmSolicitantes()
        {
            InitializeComponent();
             clsControladorConductores controladorConductor = new clsControladorConductores();
        }

        private void btnDejarTrabajar_Click(object sender, EventArgs e)
        {
            clsControladorConductores conductor = new clsControladorConductores();
            if (conductor.ejecutarDejarServicio()){
                this.Close();
            }
        }

        private void frmSolicitantes_Load(object sender, EventArgs e)
        {
            
        }

        private void timerChecker_Tick(object sender, EventArgs e)
        {
            string valorSeleccionado;
            //cmbPosiblesClientes.Items.Clear();
            clsControladorUsuarios controladorUsuario = new clsControladorUsuarios();
            DataTable infoPosiblesClientes = controladorUsuario.ejecutarUsuariosSolicitando();
            info = controladorUsuario.ejecutarUsuariosSolicitando();

        
            dtgSolicitantes.DataSource = infoPosiblesClientes;
            dtgSolicitantes.Columns[0].HeaderText = "NumeroSolicitud";
            dtgSolicitantes.Columns[1].HeaderText = "NumDocumento";
            dtgSolicitantes.Columns[2].HeaderText = "Nombre";
            dtgSolicitantes.Columns[3].HeaderText = "Apellido";
            dtgSolicitantes.Columns[4].HeaderText = "Recoges en:";
            dtgSolicitantes.Columns[5].HeaderText = "Quiere ir a:";
            dtgSolicitantes.Columns[6].HeaderText = "Precio Solicitado";


            //DataGridViewButtonColumn botonDataGrid = new DataGridViewButtonColumn();
            //botonDataGrid.Name = "btnAtenderSolicitud";
            //botonDataGrid.Text = "Atender solicitud";
            //botonDataGrid.HeaderText = "Atender Solicitud";

            //if(dtgSolicitantes.Columns["btnAtenderSolicitud"] == null)
            //{
            //    dtgSolicitantes.Columns.Insert(7, botonDataGrid);
            //}



            //clsControladorConductores controladorConductor = new clsControladorConductores();
            //dtgConductoresActivos.DataSource = controladorConductor.ejecutarConductoresActivos();

        }

        private void frmSolicitantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerChecker.Stop();
            timerChecker.Enabled = false;
        }

        private void dtgConductoresActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumSolicitud.Text = dtgSolicitantes.CurrentRow.Cells[0].Value.ToString();
        }

        private void cmbPosiblesClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(info.Rows.Count.ToString());
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            clsControladorSolicitud controladorSolicitud = new clsControladorSolicitud(Convert.ToInt32(txtNumSolicitud.Text));
            if (controladorSolicitud.ejecutarAtenderSolicitud())
            {
                MessageBox.Show("Se atendió");
                clsControladorConductores controladorConductores = new clsControladorConductores(Convert.ToInt32(txtNumSolicitud.Text));
                if (controladorConductores.ejecutarCambiarEstado())
                {
                    frmViajes viaje = new frmViajes();
                    viaje.ShowDialog();
                    this.Hide();
                }
            }
        }
    }
}
