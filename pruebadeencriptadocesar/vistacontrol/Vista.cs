using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistacontrol
{
    public class Vista
    {
        public void MostrarTorneos(char[] encyy, ListBox listaT)
        {
            listaT.Items.Clear();
            foreach (char item in encyy)
            {
                listaT.Items.Add(item);
            }
        }
    }
}
