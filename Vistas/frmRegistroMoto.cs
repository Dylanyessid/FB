using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FB
{
    public partial class frmRegistroMoto : Form
    {

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
        }
    }
}
