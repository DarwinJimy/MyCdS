using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using DBconection;
using System.Windows.Forms;

namespace Funciones
{
    public class Ejecuciones
    {

        public static void Registro_Alumno(string datos)
        {
            OleDbConnection con = DBconection.Conexxxxxion.realizar_Conexion();
            //con.Open();
            //datos = ();
            OleDbCommand cmd = new OleDbCommand(datos, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Registro guardado", "SISPROM");
            }
            else
            {
                MessageBox.Show("No se registro al alumno" , "SISPROM");
            }
        }
    }
}
