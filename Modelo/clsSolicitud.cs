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
    class clsSolicitud
    {
        private int idSolicitud;
        private string documento;
        private DateTime fecha;
        private string pais;
        private string estado;
        private string ciudad;
        private decimal precioSolicitado;
        private string recogida;
        private string destino;


        private SqlConnection solicitudConnect = clsConexion.dbConnect();

        public clsSolicitud( decimal precioSolicitado, string recogida, string destino)
        {
            PrecioSolicitado = precioSolicitado;
            Recogida = recogida;
            Destino = destino;
        }

        public clsSolicitud(DateTime fecha)
        {
            Fecha = fecha;
        }

        public clsSolicitud(int idSol)
        {
            IdSolicitud = idSol;
        }

        public string Documento { get => documento; set => documento = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public decimal PrecioSolicitado { get => precioSolicitado; set => precioSolicitado = value; }
        public string Recogida { get => recogida; set => recogida = value; }
        public string Destino { get => destino; set => destino = value; }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }

        public bool crearSolicitud()
        {
            Fecha = DateTime.Now;
            clsSesion.FechaUltimaSolicitud = Fecha;
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@documento", SqlDbType.Int).Value = clsSesion.DocumentoSesion;
            consulta.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Fecha;
            consulta.Parameters.Add("@pais", SqlDbType.VarChar).Value = clsSesion.Pais;
            consulta.Parameters.Add("@estado", SqlDbType.VarChar).Value = clsSesion.Estado;
            consulta.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = clsSesion.Ciudad;
            consulta.Parameters.Add("@precio", SqlDbType.VarChar).Value = PrecioSolicitado;
            consulta.Parameters.Add("@recogida", SqlDbType.VarChar).Value = Recogida;
            consulta.Parameters.Add("@destino", SqlDbType.VarChar).Value = Destino;

            consulta.CommandText = "insert into tblSolicitudes values (@documento, @fecha, @pais, @estado, @ciudad, @recogida, @destino, @precio, 'Buscando') ";

            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
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

        public bool cancelarSolicitud()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Fecha;
            consulta.CommandText = "UPDATE  tblSolicitudes SET estadoSolicitud='Cancelada' where fechaSolicitud=@fecha";

            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
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

        public bool atender()
        {
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = solicitudConnect;
            consulta.Parameters.Add("@idSol", SqlDbType.Int).Value = IdSolicitud;

            consulta.CommandText = "UPDATE tblSolicitudes SET estadoSolicitud='Aceptada' where idSolicitud=@idSol";

            try
            {
                if (consulta.ExecuteNonQuery() == 1)
                {
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

        
    }
}
