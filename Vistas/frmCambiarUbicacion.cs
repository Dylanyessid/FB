﻿using System;
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
            else
            {
                lblTitulo.Text = "¿Esta sigue siendo tu ubicación actual?";
            }
        }
    }
}