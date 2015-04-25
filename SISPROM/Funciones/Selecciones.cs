using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using DBconection;


namespace Funciones
{
    public static class Selecciones
    {
        public static string Existe_Usuario(string codigo)
        {

            string consulta = "Select codigo_alumno, nombre, apellido_paterno, apellido_materno From alumno where codigo_alumno = '"+codigo+"';";
            //string consulta = "Select codigo_alumno From alumno;";
            return consulta;
        
        }
        public static string Existe_curso_usuario(string codigo)
        {

            string consulta = "Select nombre_curso From curso where codigo_alumno = '" + codigo + "';";
            //string consulta = "Select codigo_alumno From alumno;";
            return consulta;

        }

        public static string Insertar_nuevo_curso(string codigoAlumno, string NombreCurso)
        {

            //string consulta = "insert into curso values ('"+NombreCurso+"','"+ codigoAlumno + "';";
            string datos = "INSERT INTO curso (nombre_curso,codigo_alumno) VALUES ('"+ NombreCurso + "','"+ codigoAlumno+ "');";
            //string consulta = "Select codigo_alumno From alumno;";
            return datos;

                           
        }
        public static string Seleccion_Cursos(string codigo)
        {
            string consulta = "Select codigo_curso, nombre_curso, codigo_alumno from curso where codigo_alumno = '"+codigo+"';";
            return consulta;
        }

        public static string hay_Notas_curso(int codigoCurso)
        {
            string consulta = "Select * from notafinal where = '" + codigoCurso + "';";
            return consulta;
        }
    }
}
