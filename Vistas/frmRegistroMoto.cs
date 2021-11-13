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

namespace FB
{
    public partial class frmRegistroMoto : Form
    {
        private bool propia;
        private string documentoPropietario;
        private string primerNombrePropietario;
        private string segundoNombrePropietario;
        private string primerApellidoPropietario;
        private string segundoApellidoPropietario;
        private string celularPropietario;
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

            if (rdoSi.Checked)
            {
                propia = true;
                documentoPropietario = clsSesion.DocumentoSesion;
                primerNombrePropietario = clsSesion.PrimerNombre;
                segundoNombrePropietario = clsSesion.SegundoNombre;
                primerApellidoPropietario = clsSesion.PrimerApellido;
                segundoApellidoPropietario = clsSesion.SegundoApellido;
                celularPropietario = clsSesion.Celular;

            }
            else if (rdoNo.Checked)
            {
                propia = false;
                documentoPropietario = txtNumDocumento.Text;
                primerNombrePropietario = txtPrimerNombre.Text;
                segundoNombrePropietario = txtSegundoNombre.Text;
                primerApellidoPropietario = txtPrimerApellido.Text;
                segundoApellidoPropietario = txtSegundoApellido.Text;
                celularPropietario = txtCelular.Text;
            }

            try
            {
                clsControladorConductores conductor = new clsControladorConductores(txtPlaca.Text, clsSesion.DocumentoSesion, dtpInicioLicencia.Value, dtpFinLicencia.Value, txtMatricula.Text, propia, dtpInicioSOAT.Value, dtpFinSOAT.Value, dtpInicioTecno.Value, dtpFinTecno.Value, txtMarca.Text, txtModelo.Text, txtLinea.Text, cmbColor.Text, Convert.ToInt32(txtCilindraje.Text), txtNumChasis.Text, txtNumMotor.Text, documentoPropietario, primerNombrePropietario, segundoNombrePropietario, primerApellidoPropietario, segundoApellidoPropietario, celularPropietario);
                if (conductor.ejecutarRegistrarComoConductor())
                {
                    this.Close();
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
