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

namespace FB
{
    public partial class frmRegistroPapelesMoto : Form
    {
        public frmRegistroPapelesMoto()
        {
            
            InitializeComponent();
        }

        private void frmRegistroPapelesMoto_Load(object sender, EventArgs e)
        {
            rdbPropia.Checked = true;
        }

        private void rdbPropia_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPropia.Checked)
            {
                lblCelular.Enabled = false;
                lblCelular.Visible = false;
                lblDocumento.Enabled = false;
                lblDocumento.Visible = false;
                lblPrimerApellido.Enabled = false;
                lblPrimerApellido.Visible = false;
                lblPrimerNombre.Enabled = false;
                lblPrimerNombre.Visible = false;
                lblSegundoApellido.Enabled = false;
                lblSegundoApellido.Visible = false;
                lblSegundoNombre.Enabled = false;
                lblSegundoNombre.Visible = false;

                txtCelular.Enabled = false;
                txtCelular.Visible = false;
                txtDocumento.Enabled = false;
                txtDocumento.Visible = false;
                txtPrimerApellido.Enabled = false;
                txtPrimerApellido.Visible = false;
                txtPrimerNombre.Enabled = false;
                txtPrimerNombre.Visible = false;
                txtSegundoApellido.Enabled = false;
                txtSegundoApellido.Visible = false;
                txtSegundoNombre.Enabled = false;
                txtSegundoNombre.Visible = false;

            }
            else
            {
                lblCelular.Enabled = true;
                lblCelular.Visible = true;
                lblDocumento.Enabled = true;
                lblDocumento.Visible = true;
                lblPrimerApellido.Enabled = true;
                lblPrimerApellido.Visible = true;
                lblPrimerNombre.Enabled = true;
                lblPrimerNombre.Visible = true;
                lblSegundoApellido.Enabled = true;
                lblSegundoApellido.Visible = true;
                lblSegundoNombre.Enabled = true;
                lblSegundoNombre.Visible = true;

                txtCelular.Enabled = true;
                txtCelular.Visible = true;
                txtDocumento.Enabled = true;
                txtDocumento.Visible = true;
                txtPrimerApellido.Enabled = true;
                txtPrimerApellido.Visible = true;
                txtPrimerNombre.Enabled = true;
                txtPrimerNombre.Visible = true;
                txtSegundoApellido.Enabled = true;
                txtSegundoApellido.Visible = true;
                txtSegundoNombre.Enabled = true;
                txtSegundoNombre.Visible = true;

            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            char propia;
            if (rdbPropia.Checked)
            {
                propia = '1';
                clsControladorMotos controladorMoto = new clsControladorMotos(Convert.ToInt32(txtMatricula.Text), propia, dtpInicioSOAT.Value, dtpFinSOAT.Value, dtpFinTecno.Value, dtpFinTecno.Value);

            }
            else if (rdbNoPropia.Checked)
            {
                propia = '0';
                clsControladorMotos controladorMoto = new clsControladorMotos(Convert.ToInt32(txtMatricula.Text), propia, dtpInicioSOAT.Value, dtpFinSOAT.Value, dtpFinTecno.Value, dtpFinTecno.Value);

            }



        }
    }
}
