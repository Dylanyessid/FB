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

        public clsControladorUsuarios(int numDocumentoIdentidad, string primerNombreUsuario, string segundoNombreUsuario, 
            string primerApellidoUsuario, string segundoApellidoUsuario, DateTime fechNacimientoUsuario, char sexo, 
            string paisActual, string estadoActual, string ciudadActual, string email, string contraseña, string celular)
        {
            usuario = new clsUsuario(numDocumentoIdentidad, primerNombreUsuario, segundoNombreUsuario, primerApellidoUsuario,
                segundoApellidoUsuario, fechNacimientoUsuario, sexo, paisActual, estadoActual, ciudadActual, email,
                contraseña, celular);
        }


        public clsControladorUsuarios(string email_o_celular, string contraseña)
        {
            usuario = new clsUsuario(email_o_celular,contraseña);
        }

        public void controladorLogin(DataGridView test)
        {

            DataTable info = usuario.loginUsuario();
            test.DataSource = info;
            
        }
    }
}
