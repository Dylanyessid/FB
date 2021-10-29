using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FB.Modelo;
using System.Windows.Forms;

namespace FB.Controladores
{
    class clsControladorMotos
    {
        private clsMoto usuario;

        public clsControladorMotos(string placa, string marcaMoto, string modeloMoto, string lineaMoto, string color, int cilindraje, string numChasis, string numMotor)
        {
            usuario = new clsMoto(placa, marcaMoto, modeloMoto, lineaMoto, color, cilindraje, numChasis, numMotor);
        }
        public clsControladorMotos(int numeroMatricula, char motoPropia, DateTime inicioSOAT, DateTime finSOAT, DateTime inicioTecnomecanica, DateTime finTecnomecanica)
        {
            usuario = new clsMoto(numeroMatricula, motoPropia, inicioSOAT, finSOAT, inicioTecnomecanica, finTecnomecanica);
        }

        public bool ejecutarIngresarDetallesMoto()
        {
           if(usuario.registrarDetallesMoto())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarRegistrarPapeles()
        {
            if (usuario.registrarPapelesMoto())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ejecutarRegistrarPropietario()
        {
            
            if (usuario.registrarPropietarioMoto())
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
