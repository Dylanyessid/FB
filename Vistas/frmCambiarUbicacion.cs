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
using FB.Vistas;

namespace FB.Vistas
{
    public partial class frmCambiarUbicacion : Form
    {
        private bool nuevo;

        public bool Nuevo { get => nuevo; set => nuevo = value; }

        public frmCambiarUbicacion(bool nuevo)
        {
            InitializeComponent();
            Nuevo = nuevo;

            
        }

        private void frmCambiarUbicacion_Load(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                lblRecogida.Visible = false;
                txtRecogida.Enabled = false;
                txtRecogida.Visible = false;
                lblDestino.Visible = false;
                txtDestino.Enabled = false;
                txtDestino.Visible = false;
                btnCambiarUbicacion.Enabled = false;
                btnCambiarUbicacion.Visible = false;
               
                lblTitulo.Text = "Escoge tu ubicación actual, por favor";
            }
            else if (!Nuevo && !clsSesion.OfreciendoServicio)
            {
                lblRecogida.Visible = true;
                txtRecogida.Enabled = true;
                txtRecogida.Visible = true;
                lblDestino.Visible = true;
                txtDestino.Enabled = true;
                txtDestino.Visible = true;
                btnCambiarUbicacion.Enabled = true;
                btnCambiarUbicacion.Visible = true;
                lblTitulo.Text = "¿Esta sigue siendo tu ubicación actual?, Si es así, pulse en 'Pedir transporte' ";
                txtCiudad.Enabled = false;
                txtEstado.Enabled = false;
                txtPais.Enabled = false;
                txtPais.Text = clsSesion.Pais;
                txtCiudad.Text = clsSesion.Ciudad;
                txtEstado.Text = clsSesion.Estado;
            }
            else if (!Nuevo && clsSesion.OfreciendoServicio)
            {
                lblTitulo.Text = "¿Esta sigue siendo tu ubicación actual?, Si es así, pulse en 'Ponerse en Servicio' ";
                btnConfirmar.Text = "Ponerse en Servicio";
                lblRecogida.Visible = false;
                txtRecogida.Enabled = false;
                txtRecogida.Visible = false;
                lblDestino.Visible = false;
                txtDestino.Enabled = false;
                txtDestino.Visible = false;
                btnCambiarUbicacion.Enabled = true;
                btnCambiarUbicacion.Visible = true;
                txtCiudad.Enabled = false;
                txtEstado.Enabled = false;
                txtPais.Enabled = false;
                txtPais.Text = clsSesion.Pais;
                txtCiudad.Text = clsSesion.Ciudad;
                txtEstado.Text = clsSesion.Estado;
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                frmPrincipal principal = new frmPrincipal();
                this.Hide();
                principal.ShowDialog();

            }
            else if (!Nuevo && clsSesion.OfreciendoServicio == false)
            {
                if (btnConfirmar.Text == "Pedir Transporte")
                {
                    frmConductoresDisponibles formConductores = new frmConductoresDisponibles(txtRecogida.Text, txtDestino.Text);
                    this.Hide();
                    formConductores.ShowDialog();
                    this.Show();
                }
                else if (btnConfirmar.Text == "Guardar cambios de ubicación")
                {
                    clsControladorUsuarios usuario = new clsControladorUsuarios(txtPais.Text, txtEstado.Text, txtCiudad.Text);
                    usuario.ejecutarCambiarUbicacion();
                    txtCiudad.Text = clsSesion.Ciudad;
                    txtEstado.Text = clsSesion.Estado;
                    txtPais.Text = clsSesion.Pais;
                    txtCiudad.Enabled = false;
                    txtEstado.Enabled = false;
                    txtPais.Enabled = false;

                    if (!clsSesion.OfreciendoServicio)
                    {
                        btnConfirmar.Text = "Pedir Transporte";
                    }
                    else
                    {
                        btnConfirmar.Text = "Ponerse en Servicio";
                    }

                    btnCambiarUbicacion.Text = "Cambiar ubicación";
                }

            }
            else if (clsSesion.OfreciendoServicio)
            {
                if (btnConfirmar.Text == "Ponerse en Servicio")
                {
                    clsControladorConductores conductor = new clsControladorConductores();
                    
                    if (conductor.ejecutarPrestarServicio())
                    {
                        frmSolicitantes solicitantesForm = new frmSolicitantes();
                        this.Hide();
                        solicitantesForm.ShowDialog();
                        this.Show();

                    }

                }
                else if (btnConfirmar.Text == "Guardar cambios de ubicación")
                {
                    clsControladorUsuarios usuario = new clsControladorUsuarios(txtPais.Text, txtEstado.Text, txtCiudad.Text);
                    usuario.ejecutarCambiarUbicacion();
                    txtCiudad.Text = clsSesion.Ciudad;
                    txtEstado.Text = clsSesion.Estado;
                    txtPais.Text = clsSesion.Pais;
                    txtCiudad.Enabled = false;
                    txtEstado.Enabled = false;
                    txtPais.Enabled = false;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarUbicacion_Click(object sender, EventArgs e)
        {
            if(btnCambiarUbicacion.Text == "Descartar Cambios")
            {
                txtEstado.Text = clsSesion.Estado;
                txtCiudad.Text = clsSesion.Ciudad;
                txtPais.Text = clsSesion.Pais;
                txtPais.Enabled = false;
                txtEstado.Enabled = false;
                txtCiudad.Enabled = false;
                if (!clsSesion.OfreciendoServicio)
                {
                    btnConfirmar.Text = "Pedir Transporte";
                }
                else
                {
                    btnConfirmar.Text = "Ponerse en Servicio";
                }
                btnCambiarUbicacion.Text = "Cambiar ubicación";

            }
            else if(btnCambiarUbicacion.Text == "Cambiar ubicación")
            {
                txtPais.Enabled = true;
                txtEstado.Enabled = true;
                txtCiudad.Enabled = true;
                btnConfirmar.Text = "Guardar cambios de ubicación";
                btnCambiarUbicacion.Text = "Descartar Cambios";
            }
           

        }
    }
}
