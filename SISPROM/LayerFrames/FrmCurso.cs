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
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {


            config_DGV();            
            TxtCodigoAlumno.Text = LblCodigo.Text;
        }

        private void config_DGV()
        {
            //DGVCursos.c
            DGVCursos.Columns[0].Width = 30;
            DGVCursos.Columns[1].Width = 200;
            DGVCursos.Columns[2].Width = 90;
            DGVCursos.Columns[0].HeaderText = "ID";
            DGVCursos.Columns[1].HeaderText = "CURSO";
            DGVCursos.Columns[2].HeaderText = "ALUMNO";
        }
        public void usuario_Actual_Curso(string user, string codigo)
        {
            LblUser.Text = user.ToString();
            LblCodigo.Text = codigo.ToString();
            TxtCodigoAlumno.Text = codigo.ToString();
        }

        private void BtnNuevoCurso_Click(object sender, EventArgs e)
        {
            TxtCodigoAlumno.Text = LblCodigo.Text;
            cargarDatosCurso(LblCodigo.Text);
            config_DGV();
        }

      

        private void BtnGuardarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = DBconection.Conexxxxxion.realizar_Conexion();
                //con.Open();
                string consulta = Selecciones.Insertar_nuevo_curso(TxtCodigoAlumno.Text.ToString(),TxtNombreCurso.Text.ToString());
                OleDbCommand cmd = new OleDbCommand(consulta, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("El alumno "+LblUser.Text + " agrego un nuevo curso exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void DGVCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LblCodigo.Text = DGVCursos.CurrentRow.Cells[0].Value.ToString();
            TxtNombreCurso.Text = DGVCursos.CurrentRow.Cells[1].Value.ToString();
            TxtCodigoAlumno.Text = DGVCursos.CurrentRow.Cells[2].Value.ToString();
        }

        private void cargarDatosCurso(string codigo)
        {
            try
            {

                OleDbConnection con = DBconection.Conexxxxxion.realizar_Conexion();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                //string consulta = "SELECT * FROM curso WHERE curso.codigo_alumno = '"+codigo+"';";
               // string consulta = "SELECT * FROM curso ;";
                //cmd.CommandText = consulta;
                cmd.CommandText = Funciones.Selecciones.Seleccion_Cursos(codigo);
                con.Close();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVCursos.DataSource = dt;


            }
            catch (Exception sds)
            {

                MessageBox.Show(sds.Message);
            }

        }

        private void BtnNotas_curso_Click(object sender, EventArgs e)
        {
            try
            {
                
                OleDbConnection con = DBconection.Conexxxxxion.realizar_Conexion();
                //con.Open();
                string consulta = Selecciones.hay_Notas_curso(int.Parse(TxtNombreCurso.Text));
                OleDbCommand cmd = new OleDbCommand(consulta, con);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                
                throw;
            }

        }
        
    }
}
