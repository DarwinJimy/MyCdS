using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBconection;
using Funciones;


namespace LayerFrames
{
    public partial class FrmRegistro : Form
    {
        FrmInicio inicio = new FrmInicio();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            inicio.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = DBconection.Conexxxxxion.realizar_Conexion();
                //con.Open();
                string datos = insertar_datos_alumno();
                OleDbCommand cmd = new OleDbCommand(datos, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado", "SISPROM");
                this.Hide();
                inicio.Show();

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("          Error de concurrencia:\n" + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("          Error de operacion invalida:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string insertar_datos_alumno()
        {
            string codigo = TxtCodigoAlumno.Text;
            string nombre = TxtNombreAlumno.Text;
            string apepat = TxtApellidoPaterno.Text;
            string apemat = TxtApellidoMaterno.Text;
            string facu = TxtFacultad.Text;
            string carre = TxtCarrera.Text;

            string datos = "INSERT INTO alumno VALUES ('"
                + codigo + "','"
                + nombre + "','"
                + apepat + "','"
                + apemat + "','"
                + facu + "','"
                + carre + "')";


            return datos;

        }

        private void TxtCodigoAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            TxtCodigoAlumno.CharacterCasing = CharacterCasing.Upper;
            TxtNombreAlumno.CharacterCasing = CharacterCasing.Upper;
            TxtApellidoMaterno.CharacterCasing = CharacterCasing.Upper;
            TxtApellidoPaterno.CharacterCasing = CharacterCasing.Upper;
            TxtFacultad.CharacterCasing = CharacterCasing.Upper;
            TxtCarrera.CharacterCasing = CharacterCasing.Upper;
        }

       
    }
}
