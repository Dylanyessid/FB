using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;


namespace FB.Modelo
{
    class clsUsuario
    {
        private SqlConnection usersConnect;
        private int numDocumentoIdentidad;
        private string primerNombreUsuario;
        private string segundoNombreUsuario;
        private string primerApellidoUsuario;
        private string segundoApellidoUsuario;
        private DateTime fechNacimientoUsuario;
        private string email;
        private string contraseña;
        private string celular;
        private char sexo;
        private string paisActual;
        private string estadoActual;
        private string ciudadActual;

        private string credencialIngreso;

        public int NumDocumentoIdentidad { get => numDocumentoIdentidad; set => numDocumentoIdentidad = value; }
        public string PrimerNombreUsuario { get => primerNombreUsuario; set => primerNombreUsuario = value; }
        public string SegundoNombreUsuario { get => segundoNombreUsuario; set => segundoNombreUsuario = value; }
        public string PrimerApellidoUsuario { get => primerApellidoUsuario; set => primerApellidoUsuario = value; }
        public string SegundoApellidoUsuario { get => segundoApellidoUsuario; set => segundoApellidoUsuario = value; }
        public DateTime FechNacimientoUsuario { get => fechNacimientoUsuario; set => fechNacimientoUsuario = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string PaisActual { get => paisActual; set => paisActual = value; }
        public string EstadoActual { get => estadoActual; set => estadoActual = value; }
        public string CiudadActual { get => ciudadActual; set => ciudadActual = value; }
        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Celular { get => celular; set => celular = value; }
        public string CredencialIngreso { get => credencialIngreso; set => credencialIngreso = value; }

        public clsUsuario(int numDocumentoIdentidad, string primerNombreUsuario, string segundoNombreUsuario, string primerApellidoUsuario, string segundoApellidoUsuario, DateTime fechNacimientoUsuario, char sexo, string paisActual, string estadoActual, string ciudadActual, string email, string contraseña, string celular)
        {
            NumDocumentoIdentidad = numDocumentoIdentidad;
            PrimerNombreUsuario = primerNombreUsuario;
            SegundoNombreUsuario = segundoNombreUsuario;
            PrimerApellidoUsuario = primerApellidoUsuario;
            SegundoApellidoUsuario = segundoApellidoUsuario;
            FechNacimientoUsuario = fechNacimientoUsuario;
            Sexo = sexo;
            PaisActual = paisActual;
            EstadoActual = estadoActual;
            CiudadActual = ciudadActual;
            Email = email;
            Contraseña = contraseña;
            Celular = celular;
            usersConnect = clsConexion.dbConnect();
        }

        public clsUsuario (string email_o_celular, string contraseña)
        {
            CredencialIngreso = email_o_celular;
            Contraseña = contraseña;
            
            usersConnect = clsConexion.dbConnect();
        }

        public void obtenerUsuarioUnico()
        {

        }

        public DataTable loginUsuario()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@credencial", SqlDbType.VarChar).Value = CredencialIngreso;
            consulta.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = Contraseña;
            consulta.CommandText = "select * from tblCredenciales where (emailUsuario=@credencial or celular=@credencial) and contraseña=@contraseña";

            SqlDataReader lista = consulta.ExecuteReader();
            DataTable info = new DataTable();
            info.Load(lista);

            return info;

        }

    }
}
