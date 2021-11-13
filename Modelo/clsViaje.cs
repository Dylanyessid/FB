using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace FB.Modelo
{
    class clsViaje
    {
		private int idViaje, idSolicitud, idMetodoPago;
		private string numDocumentoPasajero,numDocumentoConductor;
		private DateTime fechaInicio,fechaFina;
		private decimal calificacionConductor;

        public clsViaje(int idSolicitud, int idMetodoPago, string numDocumentoPasajero, string numDocumentoConductor, DateTime fechaInicio, DateTime fechaFina, decimal calificacionConductor)
        {
            IdSolicitud = idSolicitud;
            IdMetodoPago = idMetodoPago;
            NumDocumentoPasajero = numDocumentoPasajero;
            NumDocumentoConductor = numDocumentoConductor;
            FechaInicio = fechaInicio;
            FechaFina = fechaFina;
            CalificacionConductor = calificacionConductor;
        }

        public int IdViaje { get => idViaje; set => idViaje = value; }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public int IdMetodoPago { get => idMetodoPago; set => idMetodoPago = value; }
        public string NumDocumentoPasajero { get => numDocumentoPasajero; set => numDocumentoPasajero = value; }
        public string NumDocumentoConductor { get => numDocumentoConductor; set => numDocumentoConductor = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFina { get => fechaFina; set => fechaFina = value; }
        public decimal CalificacionConductor { get => calificacionConductor; set => calificacionConductor = value; }
    }
}
