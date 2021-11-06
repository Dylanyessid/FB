using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
using FB.Modelo;

namespace FB.Modelo
{
    class clsConductor
    {
        private SqlConnection usersConnect = clsConexion.dbConnect();

        private string placaMoto;
		private string numDocumentoIdentidad;
		private decimal calificacionPromedio;
		private char activo;
		private DateTime licenciaDesde;
		private DateTime licenciaHasta;
		private int solicitudActual;
        public string PlacaMoto { get => placaMoto; set => placaMoto = value; }
        public string NumDocumentoIdentidad { get => numDocumentoIdentidad; set => numDocumentoIdentidad = value; }
        public DateTime LicenciaDesde { get => licenciaDesde; set => licenciaDesde = value; }
        public DateTime LicenciaHasta { get => licenciaHasta; set => licenciaHasta = value; }
        public int SolicitudActual { get => solicitudActual; set => solicitudActual = value; }
        public decimal CalificacionPromedio { get => calificacionPromedio; set => calificacionPromedio = value; }
        public char Activo { get => activo; set => activo = value; }


        public clsConductor(string numDoc, DateTime licenciaDesde, DateTime licenciaHasta)
        { 
            LicenciaDesde = licenciaDesde;
            LicenciaHasta = licenciaHasta;
            NumDocumentoIdentidad = numDoc;
        }

        public clsConductor()
        {
            
        }

        public clsConductor(int solicitudActual)
        {
            SolicitudActual = solicitudActual;
        }

        //Metodo para registrar conductor por primera vez
        public bool registrarConductor()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.CommandText = "insert into tblConductores values (@placa, @numDocumento, 0, 0,0, @licenciaDesde, @licenciaHasta, null)";
            consulta.Parameters.Add("@placa", SqlDbType.VarChar).Value = clsSesion.PlacaMoto;
            consulta.Parameters.Add("@numDocumento", SqlDbType.VarChar).Value = NumDocumentoIdentidad;
            consulta.Parameters.Add("@licenciaDesde", SqlDbType.Date).Value = LicenciaDesde;
            consulta.Parameters.Add("@licenciaHasta", SqlDbType.Date).Value = LicenciaHasta;
           
            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
        //Metodo para indicar que se quiere prestar servicio
        public bool prestarServicio()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = clsSesion.DocumentoSesion;
            consulta.CommandText = "UPDATE tblConductores SET activo='1' where numDocumentoIdentidad=@documento" ;
            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Te has puesto en servicio");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

        }

        //Metodo para dejar de prestar servicio
        public bool dejarServicio()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = clsSesion.DocumentoSesion;
            consulta.CommandText = "UPDATE tblConductores SET activo='0' where numDocumentoIdentidad=@documento";
            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Has dejado de estar en servicio");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        //Metodo para mostrar los conductores activos
        public DataTable conductoresActivos()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = clsSesion.Ciudad;
            consulta.Parameters.Add("@estado", SqlDbType.VarChar).Value = clsSesion.Estado;
            consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = clsSesion.Pais;
            consulta.CommandText = "select * from conductoresActivos where ciudadActual=@ciudad and estadoActual=@estado and paisActual=@pais order by calificacionPromedio DESC";

            SqlDataReader listaConductoresActivos = consulta.ExecuteReader();
            DataTable infoConductoresActivos = new DataTable();
            infoConductoresActivos.Load(listaConductoresActivos);

            return infoConductoresActivos;
        }

        //Metodo para establecer si un conductor está o no en una solicitud
        public bool cambiarSolicitudConductor()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = usersConnect;
            if (SolicitudActual > 0)
            {
                consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = SolicitudActual;

            }
            else
            {
                consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = null;
            }
            consulta.Parameters.Add("@documento", SqlDbType.VarChar).Value = clsSesion.DocumentoSesion;
            consulta.CommandText = "UPDATE tblConductores SET solicitudActual=@idSol where numDocumentoIdentidad=@documento";

            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

        }
    }
}
