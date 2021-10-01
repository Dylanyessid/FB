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
            string email = txtEmail.Text;
            try
            {
                SqlConnection con = new SqlConnection("server=LAPTOP-6N13TOH0\\SQLEXPRESS;database=dboFastBike;integrated security=true");
                con.Open();
                string query = "select * from tblCredenciales where (emailUsuario='" + txtEmail.Text + "' or celular='" +txtEmail.Text + "') and contraseña='" + txtPassword.Text + "'";
                SqlCommand consulta = new SqlCommand(query, con);
               

                SqlDataReader lista = consulta.ExecuteReader();
                DataTable info = new DataTable();
                info.Load(lista);
                dataGridView1.DataSource = info;
                if (info.Rows.Count == 1)
                {
                    MessageBox.Show("Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("No ha ingresado correctamente sus datos");
                }
                
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
