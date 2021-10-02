using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using MaterialSkin.Animations;
using System.Data.SqlClient;
using FB.Controladores;

namespace FB
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.Font = new System.Drawing.Font(
                      "Roboto",
                      32F,
                      System.Drawing.FontStyle.Regular,
                      System.Drawing.GraphicsUnit.Point,
                      ((byte)(0)));
        }

        private void label1_Click(object sender, EventArgs e)
        {


            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            
            
            try
            {

               Controladores.clsControladorUsuarios peticionIngreso = new Controladores.clsControladorUsuarios(txtEmail.Text, txtPassword.Text);
                peticionIngreso.controladorLogin(dataGridView1);
                
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.ShowDialog();
        }
    }
}
