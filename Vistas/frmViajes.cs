﻿using System;
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

namespace FB.Vistas
{
    public partial class frmViajes : Form
    {
        string recogida, nombres, celular, documentoPasajero;
        string destino;
        int idConductor;
        int solicitudActual;
        decimal precio;
        bool conductor;
        decimal calificacionPromedio;
        bool viajeFinalizado = false;
        DateTime horaInicioViaje;
        DataTable dtMetodosPago;
        clsControladorSolicitud controladorSolicitud;
        public frmViajes(int solicitudActual, string recogida, string destino, decimal precio, bool conductor, string nombres, string celular, string documento)
        {
            InitializeComponent();
            this.recogida = recogida;
            this.destino = destino;
            this.precio = precio;
            this.conductor = conductor;
            this.solicitudActual = solicitudActual;
            this.documentoPasajero = documento;
            this.nombres = nombres;
            this.celular = celular;
            lblCelular.Text = celular;
        }
        public frmViajes(int solicitudActual, string recogida, string destino, decimal precio, bool conductor, string nombres, string celular, decimal calificacionProm, int idConductor)
        {
            InitializeComponent();
            this.recogida = recogida;
            this.destino = destino;
            this.precio = precio;
            this.conductor = conductor;
            this.solicitudActual = solicitudActual;
            this.nombres = nombres;
            this.celular = celular;
            this.calificacionPromedio = calificacionProm;
            this.idConductor = idConductor;
        }

        private void frmViajes_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombres;
            lblCelular.Text = celular;
            lblCalificacion.Text = calificacionPromedio.ToString();
            grpCalificacion.Visible = false;

            if (!conductor)
            {
                lblCalificacion.Text = calificacionPromedio.ToString();
            }
            else
            {
                lblCliente.Text = "Cliente: ";
            }
            

            rdoEfectivo.Visible = false;
            rdoMetodoPago.Visible = false;
            grpPago.Visible = false;

           clsControladorMetodoPago metodoPago = new clsControladorMetodoPago(clsSesion.DocumentoSesion);
             dtMetodosPago = metodoPago.ejecutarConsultarMetodosPago();

           
            if(dtMetodosPago.Rows.Count > 0)
            {
                foreach (DataRow metodo in dtMetodosPago.Rows)
                {
                    string key = "jwey89e09ewhfo24";

                    FB.secret.Encrypt encrypt = new FB.secret.Encrypt();
                    string numTajeta = encrypt.decrypt(metodo["numeroTarjeta"].ToString(), key);
                    string tipo = encrypt.decrypt(metodo["tipoTarjeta"].ToString(), key);
                    string concepto = encrypt.decrypt(metodo["concepto"].ToString(), key);
                    cmbMetodosPago.Items.Add("Tarjeta de: " + tipo + "  ||  " + concepto + "  ||  " + numTajeta);
                }
            }
            

            lblDestino.Text = destino;
            lblRecogida.Text = recogida;
            lblPrecio.Text = precio.ToString();
            btnTerminarViaje.Visible = false;
            btnPagarViaje.Visible = false;
            cmbMetodosPago.Visible = false;

            if (!conductor)
            {
                lblTituloDestino.Text = "Quieres ir a:";
                lblTituloRecogida.Text = "Dirección de tu recogida:";
                btnReportarRecogida.Visible = false;
                btnReportarRecogida.Text = "Sí me han recogido";
                horaInicioViaje = DateTime.Now;
            }
        }

        private void btnReportarRecogida_Click(object sender, EventArgs e)
        {
            if(btnReportarRecogida.Text == "Sí me han recogido")
            {
                try
                {
                    controladorSolicitud = new clsControladorSolicitud(solicitudActual);
                    controladorSolicitud.ejecutarConfirmarRecogida();
                    horaInicioViaje = DateTime.Now;
                    lblEstadoViaje.Text = "Viajando";
                    btnReportarRecogida.Visible = false;
                }
                catch (Exception err)
                {
                       MessageBox.Show(err.Message);
                }

            }
            else
            {
                try
                {
                    clsControladorSolicitud controladorSolicitud = new clsControladorSolicitud(solicitudActual);
                    controladorSolicitud.ejecutarClienteRecogido();
                    btnReportarRecogida.Enabled = false;
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            
        }

        private void timerChecker_Tick(object sender, EventArgs e)
        {
            if (conductor)
            {
                string estado;
                clsControladorSolicitud controladorSolictud = new clsControladorSolicitud(solicitudActual);
                DataTable registroSolicitud = controladorSolictud.ejecutarConsultarSolicitud();
                estado = registroSolicitud.Rows[0]["estadoSolicitud"].ToString();
                if (estado == "Viajando")
                {
                    lblEstadoViaje.Text = "Viajando";
                    btnTerminarViaje.Visible = true;
                    btnReportarRecogida.Visible = false;
                }
                else if (estado == "Pago Pendiente")
                {
                    lblEstadoViaje.Text = "Esperando Pago del Cliente";
                }
            }
            else
            {
                grpCalificacion.Visible = false;
                string estado;
                clsControladorSolicitud controladorSolictud = new clsControladorSolicitud(solicitudActual);
                DataTable registroSolicitud = controladorSolictud.ejecutarConsultarSolicitud();
                estado = registroSolicitud.Rows[0]["estadoSolicitud"].ToString();
                if (estado == "Recogido?")
                {
                    lblEstadoViaje.Text = "El condutor ha reportado\r\nque te ha recogido. Si no es cierto, repórtanos.";
                    btnReportarRecogida.Visible = true;
                }
                else if (estado == "Finalizado?")
                {
                    lblEstadoViaje.Text = "El condutor ha reportado\r\nque te ha llegado al destino. Si no es cierto, repórtanos.";
                    btnTerminarViaje.Text = "Sí, he llegado a mi destino";
                    btnTerminarViaje.Visible = true;
                }
                else if(estado == "Pago Pendiente")
                {
                    lblEstadoViaje.Text = "Concluyó el viaje. Selecciona un método de pago";
                    cmbMetodosPago.Visible = true;
                    btnPagarViaje.Visible = true;
                    btnTerminarViaje.Visible = false;
                    rdoEfectivo.Visible = true;
                    rdoMetodoPago.Visible = true;
                    rdoEfectivo.Checked = true;
                    grpPago.Visible = true;
                    grpCalificacion.Visible = true;
                    timerChecker.Stop();
                    

                    if(dtMetodosPago.Rows.Count == 0)
                    {
                        lblEstadoViaje.Text = "Concluyó el viaje. Solo puedes pagar en \r\nefectivo, ya que no tienes ningún metodo de pago añadido.";
                        rdoEfectivo.Checked = true;
                        rdoMetodoPago.Enabled = false;
                        cmbMetodosPago.Visible = false;
                        cmbMetodosPago.Enabled = false;

                    }

                }
            }
            
            
        }

        private void rdoMetodoPago_CheckedChanged(object sender, EventArgs e)
        {

            cmbMetodosPago.Visible = true;
            cmbMetodosPago.Enabled = true;
        }

        private void rdoEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbMetodosPago.Visible = false;
            cmbMetodosPago.Enabled = false;
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            DialogResult drAlerta = MessageBox.Show("Al reportar un problema se interrumpiría la solicitud. Si ya estás con el conductor, pídele que te baje. ", "Alerta", MessageBoxButtons.YesNo);
            if (drAlerta == DialogResult.Yes)
            {
                clsControladorSolicitud controladorSolicitud = new clsControladorSolicitud(clsSesion.SolicitudActual);
                if (controladorSolicitud.ejecutarInterrumpirSolicitud())
                {
                    frmReporte frmReporte = new frmReporte();
                    this.Hide();
                    frmReporte.ShowDialog();

                }
            }
        }
        private void frmViajes_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerChecker.Stop();
            timerChecker.Enabled = false;
        }

        private void btnTerminarViaje_Click(object sender, EventArgs e)
        {
            if(btnTerminarViaje.Text == "Ya llegué al destino.")
            {
                try
                {
                    clsControladorSolicitud controladorSolictud = new clsControladorSolicitud(solicitudActual);
                    controladorSolictud.ejecutarLlegarDestino();
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
                
            }
            else if (btnTerminarViaje.Text == "Sí, he llegado a mi destino")
            {
                try
                {
                    clsControladorSolicitud controladorSolictud = new clsControladorSolicitud(solicitudActual);
                    controladorSolictud.ejecutarConfirmarLlegarDestino();
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }



        private void btnPagarViaje_Click(object sender, EventArgs e)
        {
            
            clsControladorConductores controladorConductor = new clsControladorConductores(idConductor, solicitudActual);
            DataTable infoConductor = controladorConductor.ejecutarInfoConductor();
            string documentoIdentidadConductor = infoConductor.Rows[0]["numDocumentoIdentidad"].ToString();
            int idMetodoPago = 0;
            decimal calificacion = 0;
            string formaPago;

            if (rdoEfectivo.Checked)
            {
                formaPago = "Efectivo";
            }
            else
            {
                formaPago = "Método Registrado";
                idMetodoPago = Convert.ToInt32(dtMetodosPago.Rows[cmbMetodosPago.SelectedIndex]["idMetodoPago"]);
            }

            if (rdo1.Checked)
            {
                calificacion = 1;
            }
            else if (rdo2.Checked)
            {
                calificacion = 2;
            }
            else if (rdo3.Checked)
            {
                calificacion = 3;
            }
            else if (rdo4.Checked)
            {
                calificacion = 4;
            }
            else if (rdo5.Checked)
            {
                calificacion = 5;
            }

            clsControladorViaje controladorViaje = new clsControladorViaje(solicitudActual, clsSesion.DocumentoSesion, documentoIdentidadConductor, formaPago, horaInicioViaje, DateTime.Now, calificacion, idMetodoPago);
            if (controladorViaje.ejecutarRegistrarViaje())
            {
                this.Close();
            }
         }
    }
}
