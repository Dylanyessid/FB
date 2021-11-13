using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FB.Modelo;
using System.Data;


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
        public clsControladorSolicitud(int idSol, int idConductor)
        {
            solicitud = new clsSolicitud(idSol, idConductor);
        }
        public clsControladorSolicitud(int idSol)
        {
            solicitud = new clsSolicitud(idSol);
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

        public bool ejecutarAtenderSolicitud()
        {
            if (solicitud.atender())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarAceptarConductorSolicitud()
        {
            if (solicitud.aceptarConductorSolicitud())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ejecutarConsultarSolicitud()
        {
            return solicitud.consultarSolicitud();
        }
       
    }
}
