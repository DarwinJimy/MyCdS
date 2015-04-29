using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones
{
    public  class Botones
    {
        public  bool activar_desactivar_botones(Button btn1, Button btn2)
        {
            if (btn1.Enabled == true && btn2.Enabled == true)
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                return true;
            }
            if (btn1.Enabled == false && btn2.Enabled == false)
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                return true;
            }
            return false;
        }
    }
}
