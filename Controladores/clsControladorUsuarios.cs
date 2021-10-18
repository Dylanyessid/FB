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
    class clsControladorUsuarios
    {
        
        private clsUsuario usuario;

        //Constructor para registrar
        public clsControladorUsuarios(int numDocumentoIdentidad, string primerNombreUsuario, string segundoNombreUsuario, 
            string primerApellidoUsuario, string segundoApellidoUsuario, DateTime fechNacimientoUsuario, string sexo, 
            string paisActual, string estadoActual, string ciudadActual)
        {
            usuario = new clsUsuario(numDocumentoIdentidad, primerNombreUsuario, segundoNombreUsuario, primerApellidoUsuario,
                segundoApellidoUsuario, fechNacimientoUsuario, sexo, paisActual, estadoActual, ciudadActual);
        }

        //Constructor para ingresar
        public clsControladorUsuarios(string email_o_celular, string contraseña)
        {
            usuario = new clsUsuario(email_o_celular,contraseña);
        }

        //Constructor para agregar las credenciales
        public clsControladorUsuarios(int documento, string email, string password, string celular)
        {
            usuario = new clsUsuario(documento,email,password,celular);
        }

        public bool controladorLogin()
        {

            DataTable info = usuario.loginUsuario();
            
            if(info.Rows.Count == 1)
            {
                MessageBox.Show(clsSesion.DocumentoSesion.ToString());
                return true;
                
            }
            else
            {
                return false;
            }
            
        }
        public bool ejecutarRegistrarUsuario()
        {
            if (usuario.registrarUsuario())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool ejecutarRegistrarCredenciales()
        {
            if (usuario.registrarCredenciales())
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
