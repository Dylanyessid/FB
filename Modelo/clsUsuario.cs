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
        private string sexo;
        private string paisActual;
        private string estadoActual;
        private string ciudadActual;
        private decimal saldo;
        private string rol;
        private string estadoCuenta;
        private string credencialIngreso;
        public int NumDocumentoIdentidad { get => numDocumentoIdentidad; set => numDocumentoIdentidad = value; }
        public string PrimerNombreUsuario { get => primerNombreUsuario; set => primerNombreUsuario = value; }
        public string SegundoNombreUsuario { get => segundoNombreUsuario; set => segundoNombreUsuario = value; }
        public string PrimerApellidoUsuario { get => primerApellidoUsuario; set => primerApellidoUsuario = value; }
        public string SegundoApellidoUsuario { get => segundoApellidoUsuario; set => segundoApellidoUsuario = value; }
        public DateTime FechNacimientoUsuario { get => fechNacimientoUsuario; set => fechNacimientoUsuario = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string PaisActual { get => paisActual; set => paisActual = value; }
        public string EstadoActual { get => estadoActual; set => estadoActual = value; }
        public string CiudadActual { get => ciudadActual; set => ciudadActual = value; }
        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Celular { get => celular; set => celular = value; }
        public string CredencialIngreso { get => credencialIngreso; set => credencialIngreso = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public string Rol { get => rol; set => rol = value; }
        public string EstadoCuenta { get => estadoCuenta; set => estadoCuenta = value; }

        
        public clsUsuario (string email_o_celular, string contraseña)
        {
            CredencialIngreso = email_o_celular;
            Contraseña = contraseña;
            
            usersConnect = clsConexion.dbConnect();
        }

        //Toca revisar este constructor
        public clsUsuario(int numDocumentoIdentidad, string primerNombreUsuario, string segundoNombreUsuario, string primerApellidoUsuario, string segundoApellidoUsuario, DateTime fechNacimientoUsuario, string sexo, string paisActual, string estadoActual, string ciudadActual)
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
            Saldo = saldo;
            Rol = rol;
            EstadoCuenta = estadoCuenta;
            usersConnect = clsConexion.dbConnect();
        }

        public clsUsuario(int documento, string email, string password, string celular)
        {
            NumDocumentoIdentidad = documento;
            Email = email;
            Contraseña = password;
            Celular = celular;
            usersConnect = clsConexion.dbConnect();
        }

        public void obtenerUsuarioUnico()
        {

        }

        public bool registrarUsuario()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "insert into tblUsuarios values (@documento, @primerNom, @segundoNom, " +
                "@primerApe, @segundoApe, @fechaNacimiento, @sexo, @pais, @estado, @ciudad, '0' , 'Usuario', 'Activo')";
            consulta.Parameters.Add("@documento", SqlDbType.Int).Value = numDocumentoIdentidad;
            consulta.Parameters.Add("@primerNom", SqlDbType.VarChar).Value = primerNombreUsuario;
            consulta.Parameters.Add("@segundoNom", SqlDbType.VarChar).Value = segundoNombreUsuario;
            consulta.Parameters.Add("@primerApe", SqlDbType.VarChar).Value = primerApellidoUsuario;
            consulta.Parameters.Add("@segundoApe", SqlDbType.VarChar).Value = segundoApellidoUsuario;
            consulta.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = fechNacimientoUsuario;
            consulta.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
            consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = paisActual;
            consulta.Parameters.Add("@estado", SqlDbType.VarChar).Value = estadoActual;
            consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = ciudadActual;

            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Si :D");
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

            return false;
        }

        public bool registrarCredenciales()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "insert into tblCredenciales values (@documento, @email, @password, @celular)";

            consulta.Parameters.Add("documento", SqlDbType.Int).Value = numDocumentoIdentidad;
            consulta.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            consulta.Parameters.Add("@password", SqlDbType.VarChar).Value = contraseña;
            consulta.Parameters.Add("@celular", SqlDbType.VarChar).Value = celular;

            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Credenciales :D");
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

            return false;
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
            clsSesion.DocumentoSesion = Convert.ToInt32(info.Rows[0]["numDocumentoIdentidad"]);

            
            //MessageBox.Show(info.Rows[0]["numDocumentoIdentidad"].ToString());
            return info;

        }

    }
}
