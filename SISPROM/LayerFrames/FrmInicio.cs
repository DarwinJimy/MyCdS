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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
            this.Hide();

        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
             try
            {
                OleDbConnection con = DBconection.Conexxxxxion.realizar_Conexion();
                //con.Open();
                string consulta = "Select * from alumno";
                OleDbCommand cmd = new OleDbCommand(consulta, con);
                
                //MessageBox.Show("resultado: " + cmd.ExecuteReader().ToString());
                //cmd.ExecuteNonQuery();

                OleDbDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    BtnRegistro.Enabled = false;
                }
                else
                {
                    BtnInicioSesion.Enabled = false;
                }

            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }
        
       
    }
}
