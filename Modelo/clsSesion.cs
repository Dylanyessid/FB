using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.Modelo
{
    static class clsSesion
    {
        //private static string emailSesion;
        private static int documentoSesion;
        private static string primerNombre;
        private static string primerApellido;
        private static string pais;
        private static string estado;
        private static string ciudad;
        private static bool ofreciendoServicio;
        private static string placaMoto;

        public static int DocumentoSesion { get => documentoSesion; set => documentoSesion = value; }
        public static string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public static string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public static string Pais { get => pais; set => pais = value; }
        public static string Estado { get => estado; set => estado = value; }
        public static string Ciudad { get => ciudad; set => ciudad = value; }
        public static bool OfreciendoServicio { get => ofreciendoServicio; set => ofreciendoServicio = value; }
        public static string PlacaMoto { get => placaMoto; set => placaMoto = value; }
    }

   
}
