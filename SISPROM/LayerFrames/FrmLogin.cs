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
using DBconection;
using Funciones;

namespace LayerFrames
{
    public partial class FrmLogin : Form
    {
        FrmPrincipal principal = new FrmPrincipal();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = DBconection.Conexxxxxion.realizar_Conexion();
                //con.Open();
                string consulta = CrearConsultas.Existe_Usuario(TxtClave.Text.ToString());
                OleDbCommand cmd = new OleDbCommand(consulta, con);
                
                //MessageBox.Show("resultado: " + cmd.ExecuteReader().ToString());
                //cmd.ExecuteNonQuery();

                OleDbDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Bienvenid@: " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3), "SISPROM");
                        
                        principal.Show();
                        principal.usuario_Actual("" + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3),reader.GetString(0));
                        Close();
                    }
                }
                else
                {
                   MessageBox.Show("No hay alumno para dicha clave.", "SISPROM");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtClave.CharacterCasing = CharacterCasing.Upper;
        }

       
    }
}
