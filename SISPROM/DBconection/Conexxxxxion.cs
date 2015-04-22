using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBconection.Properties;
using System.Configuration;
using System.Data.OleDb;

using System.Data.SqlClient;

namespace DBconection
{
    public class Conexxxxxion
    {
        public static string ObtenerString()
        {
            return Settings.Default.SISPRO_dbConnexxxionString;        
        }
        public static OleDbConnection realizar_Conexion()
        {
            OleDbConnection conexion = new OleDbConnection(ObtenerString());
            conexion.Open();
            return conexion;
        }
    }
}
