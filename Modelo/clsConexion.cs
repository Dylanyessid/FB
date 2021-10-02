using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FB.Modelo
{
    class clsConexion
    {
        private static SqlConnection dbConnection;

        public static SqlConnection dbConnect()
        {
            if(dbConnection == null)
            {
                dbConnection = new SqlConnection("server=LAPTOP-6N13TOH0\\SQLEXPRESS;database=dboFastBike;integrated security=true");
                try
                {
                    dbConnection.Open();
                    return dbConnection;
                }
                catch
                {
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
