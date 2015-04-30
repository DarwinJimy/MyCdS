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
            string codigo = TxtCodigoAlumno.Text;
            string nombre = TxtNombreAlumno.Text;
            string apepat = TxtApellidoPaterno.Text;
            string apemat = TxtApellidoMaterno.Text;
            string facu = TxtFacultad.Text;
            string carre = TxtCarrera.Text;

            try
            {

                Funciones.Ejecuciones.Registro_Alumno(Funciones.CrearConsultas.insert_alumno(TxtCodigoAlumno.Text.ToString() , TxtNombreAlumno.Text.ToString() ,TxtApellidoPaterno.Text.ToString(), TxtApellidoMaterno.Text.ToString(),TxtFacultad.Text.ToString(),TxtCarrera.Text.ToString()));
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
