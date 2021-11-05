﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FB.Modelo;


namespace FB.Controladores
{
    class clsControladorSolicitud
    {
        private clsSolicitud solicitud;

        public clsControladorSolicitud(decimal precioSolicitado, string recogida, string destino)
        {
            solicitud = new clsSolicitud(precioSolicitado, recogida, destino);
        }

        public clsControladorSolicitud()
        {
            solicitud = new clsSolicitud(clsSesion.FechaUltimaSolicitud);
        }

        public bool ejecutarCrearSolicitud()
        {
            if (solicitud.crearSolicitud())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarCancelarSolicitud()
        {
            if (solicitud.cancelarSolicitud())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
