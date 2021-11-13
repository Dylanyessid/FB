using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FB.Vistas
{
    public partial class frmViajes : Form
    {
        string recogida;
        string destino;
        decimal precio;
        bool conductor;
        public frmViajes(string recogida, string destino, decimal precio, bool conductor )
        {
            InitializeComponent();
            this.recogida = recogida;
            this.destino = destino;
            this.precio = precio;
            this.conductor = conductor;
        }

        private void frmViajes_Load(object sender, EventArgs e)
        {
            lblDestino.Text = destino;
            lblRecogida.Text = recogida;
            lblPrecio.Text = precio.ToString();

            if (!conductor)
            {
                lblTituloDestino.Text = "Quieres ir a:";
                lblTituloRecogida.Text = "Dirección de tu recogida:";
            }
        }

        private void btnReportarRecogida_Click(object sender, EventArgs e)
        {

        }
    }
}
