using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FB.Modelo;
namespace FB.Controladores
{
    class clsControladorViaje
    {
        clsViaje viaje;
        public clsControladorViaje(int idSolicitud, string numDocumentoPasajero, string numDocumentoConductor, string formaPago, DateTime fechaInicio, DateTime fechaFina, decimal calificacionConductor, int idMetodoPago)
        {
            viaje = new clsViaje(idSolicitud, numDocumentoPasajero, numDocumentoConductor, formaPago, fechaInicio, fechaFina, calificacionConductor, idMetodoPago);
        }

        public bool ejecutarRegistrarViaje()
        {
            if (viaje.crearViaje())
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
