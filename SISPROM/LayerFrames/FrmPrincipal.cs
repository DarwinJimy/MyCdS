using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Funciones;
namespace LayerFrames
{
    public partial class FrmPrincipal : Form
    {
        FrmCurso curso = new FrmCurso();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            /*
            */

        }
        public void usuario_Actual(string user, string codigo)
        {
            LblUsuario.Text = user.ToString();
            LblCodigo.Text = codigo.ToString();
            
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            var mesaje = MessageBox.Show("Desea cerrar de todos modos?","SISPROM");
            if (DialogResult.OK == mesaje)
            {
                Application.Exit();
            }
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = DBconection.Conexxxxxion.realizar_Conexion();
                //con.Open();
                string consultaCurso = Selecciones.Existe_curso_usuario(LblCodigo.Text.ToString());
                string consulta_User = Selecciones.Existe_Usuario(LblCodigo.Text.ToString());
                
                OleDbCommand cmd = new OleDbCommand(consultaCurso, con);
                OleDbCommand comand = new OleDbCommand(consulta_User, con);

                //MessageBox.Show("resultado: " + cmd.ExecuteReader().ToString());
                //cmd.ExecuteNonQuery();
                OleDbDataReader lector = comand.ExecuteReader();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    string cursoooos = "";
                    int i = 0;
                    while (reader.Read())
                    {
                        cursoooos = cursoooos + reader.GetString(0)+"\n";
                        
                        i = i + 1;

                    }
                    
                    MessageBox.Show("Cursos: "+i+"\n" + cursoooos);
                }
                else
                {
                    MessageBox.Show("No hay cursos para este alumno");
                }
                curso.Show();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        curso.usuario_Actual_Curso(lector.GetString(1) + " " + lector.GetString(2) + " " + lector.GetString(3), lector.GetString(0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
