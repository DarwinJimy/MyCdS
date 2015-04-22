using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
       
    }
}
