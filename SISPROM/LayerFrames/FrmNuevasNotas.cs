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
    public partial class FrmNuevasNotas : Form
    {
        public FrmNuevasNotas()
        {
            InitializeComponent();
        }

        private void FrmNuevasNotas_Load(object sender, EventArgs e)
        {

        }

        public void usuario_Actual(string user, string codigo)
        {
            LblUser.Text = user.ToString();
            LblCodigo.Text = codigo.ToString();

        }
        public void curso_Actual(string codigo, string nombre)
        {
            LblCodigoCurso.Text = codigo.ToString();
            LblNombrecurso.Text = nombre.ToString();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void TxtTF_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(TxtTF.Text.ToString())>20 || int.Parse(TxtTF.Text.ToString())<0)
            {
                MessageBox.Show("Ingrese una nota correctamente","SISPROM");
            }
            else
            {
                calcular_NF();
            }
        }
        private void TxtEF_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(TxtEF.Text.ToString()) > 20 || int.Parse(TxtEF.Text.ToString()) < 0)
            {
                MessageBox.Show("Ingrese una nota correctamente", "SISPROM");
            }
            else
            {
                calcular_NF();
            }
        }


        private void TxtP1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(TxtP1.Text.ToString()) > 20 || int.Parse(TxtP1.Text.ToString()) < 0)
            {
                MessageBox.Show("Ingrese una nota correctamente", "SISPROM");
            }
            else
            {
                calcular_PF();
            }
        }

        private void TxtNF1_TextChanged(object sender, EventArgs e)
        {
            if (TxtNF1.Text.ToString() != "")
            {
                TxtP1.Enabled = true;
                TxtP2.Enabled = true;
            }
        }

        public void calcular_NF()
        {
            int valor,n1,n2;
            n1 = int.Parse(TxtTF.Text.ToString());
            n2 = int.Parse(TxtEF.Text.ToString());
            valor = (n1+n2)/2;
            TxtNF1.Text = valor.ToString();
            TxtNF2.Text = TxtNF1.Text;
        }

        public void calcular_PF()
        {
            int p1, p2, nf, valor;
            p1 = int.Parse(TxtP1.Text.ToString());
            p2 = int.Parse(TxtP2.Text.ToString());
            nf = int.Parse(TxtNF2.Text.ToString());
            valor = ((7*p1)+(7*p2)+(6*nf))/20;
            LblPF.Text = valor.ToString();
        }

        private void TxtP2_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(TxtP2.Text.ToString()) > 20 || int.Parse(TxtP2.Text.ToString()) < 0)
            {
                MessageBox.Show("Ingrese una nota correctamente", "SISPROM");
            }
            else
            {
                calcular_PF();
            }
        }

        private void TxtNF2_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(TxtNF2.Text.ToString()) > 20 || int.Parse(TxtNF2.Text.ToString()) < 0)
            {
                MessageBox.Show("Ingrese una nota correctamente", "SISPROM");
            }
            else
            {
                calcular_PF();
            }
        }


        
    }
}
