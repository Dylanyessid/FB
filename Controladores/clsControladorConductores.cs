using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
