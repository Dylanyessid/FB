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
    public partial class frmMetodoPago : Form
    {
        private clsControladorMetodoPago metodoPago;
         
        public frmMetodoPago()
        {
            InitializeComponent();
        }

        private void frmMetodoPago_Load(object sender, EventArgs e)
        {
            cmbConcepto.Items.Add("MasterCard");
            cmbConcepto.Items.Add("Visa");
            cmbConcepto.Items.Add("American Express");
            cmbConcepto.Items.Add("Diners Club");

            cmbTipoTarjeta.Items.Add("Crédito");
            cmbTipoTarjeta.Items.Add("Débito");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string fechaVencimiento = $"{txtMesVencimiento.Text}/{txtAnoVencimiento.Text}";
            try
            {
                metodoPago = new clsControladorMetodoPago(FB.Modelo.clsSesion.DocumentoSesion,txtTarjeta.Text, fechaVencimiento, cmbTipoTarjeta.Text,cmbConcepto.Text,txtCodigoSeguridad.Text,txtCodigoPostal.Text);
                metodoPago.ejecutarAgregarMetodoPago();           
            }
            catch
            {

            }
        }

        
    }
}
