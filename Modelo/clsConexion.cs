using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FB.Modelo
{
    class clsConexion
    {
        private static SqlConnection dbConnection;

        private static string host = "192.168.1.65";
        private static string database = "dboFastBike";
        private static string security = "integrated security=false";
        private static string user = "Usuario";
        private static string password = "1904";

        public static SqlConnection dbConnect()
        {
            if(dbConnection == null)
            {
                dbConnection = new SqlConnection($"user id={user};password ={password};server={host};database={database};{security}");
                //dbConnection = new SqlConnection("server=LAPTOP-6N13TOH0\\SQLEXPRESS;database=dboFastBike;integrated security=true");
                try
                {
                    dbConnection.Open();
                    return dbConnection;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return null;
                }
            }
            else
            {
                return dbConnection;
            }
             
        }
    }
}
