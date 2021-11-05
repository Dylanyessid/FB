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
    public partial class frmSolicitantes : Form
    {
        public frmSolicitantes()
        {
            InitializeComponent();
        }

        private void btnDejarTrabajar_Click(object sender, EventArgs e)
        {
            clsControladorConductores conductor = new clsControladorConductores();
            if (conductor.ejecutarDejarServicio()){
                this.Close();
            }
        }
    }
}
