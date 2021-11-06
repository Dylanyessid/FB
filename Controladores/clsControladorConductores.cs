using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FB.Modelo;

namespace FB.Controladores
{
    class clsControladorConductores
    {
        private clsConductor conductor;
        public clsControladorConductores(string numDoc, DateTime inicioLicencia, DateTime finLicencia)
        {
            conductor = new clsConductor(numDoc, inicioLicencia, finLicencia);
        }
        public clsControladorConductores()
        {
            conductor = new clsConductor();
        }
        public clsControladorConductores(int idSol)
        {
            conductor = new clsConductor(idSol);
        }

        public bool ejecutarRegistrarConductor()
        {
            if (conductor.registrarConductor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarPrestarServicio()
        {
            if (conductor.prestarServicio())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarDejarServicio()
        {
            if (conductor.dejarServicio())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ejecutarConductoresActivos()
        {
            return conductor.conductoresActivos();
        }
        public bool ejecutarCambiarEstado()
        {
            if(conductor.cambiarSolicitudConductor())
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
