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

        private void CmbFacu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFacu.SelectedIndex == 0)
            {

                CmbCarrera.Items.Clear();
                CmbCarrera.Items.Add("SISTEMAS");
                CmbCarrera.Items.Add("SEGURIDAD");
                CmbCarrera.Items.Add("INDUSTRIAL");
                CmbCarrera.Items.Add("MINAS");
                // Seleccion del primer item de carrera
                CmbCarrera.SelectedIndex = 0;


            }
            else if (CmbFacu.SelectedIndex == 1)
            {
                CmbCarrera.Items.Clear();
                CmbCarrera.Items.Add("DERECHO");
                // Seleccion del primer item de carrera
                CmbCarrera.SelectedIndex = 0;

            }
            else
            {
                CmbCarrera.Items.Clear();
                CmbCarrera.Items.Add("NEGOCIOS INTERNACIONALES");
                CmbCarrera.Items.Add("ADMINISTRACION Y MARKETING");
                CmbCarrera.Items.Add("HOTELERIA Y TURISMO");
                CmbCarrera.Items.Add("CONTABILIDAD");
                CmbCarrera.Items.Add("ADMINISTRACION DE EMPRESAS");
                CmbCarrera.Items.Add("ADMINISTRACIO Y FINANZAS");
                // Seleccion del primer item de carrera
                CmbCarrera.SelectedIndex=0;
            }
            TxtFacultad.Text = CmbFacu.SelectedItem.ToString();
        }

        private void CmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtCarrera.Text = CmbCarrera.SelectedItem.ToString();

        }

       
    }
}
