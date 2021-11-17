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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void btnEnviarReporte_Click(object sender, EventArgs e)
        {
            clsControladorReportes reporte = new clsControladorReportes(txtDocumento.Text, txtDocumentoDenunciado.Text, txtDescripcion.Text);
            reporte.ejecutarNuevoReporte();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = FB.Modelo.clsSesion.DocumentoSesion;

        }
    }
}
