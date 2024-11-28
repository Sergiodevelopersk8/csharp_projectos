using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VistaTorneo
{
    public class Vistaclass
    {
        public void MiLetrero(string frase)
        {
            MessageBox.Show(frase, "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }


        public void MonstrarCadenas(string[] cadenas, ListBox lista)
        {
            lista.Items.Clear();

           foreach (string j in cadenas)
            {
                lista.Items.Add(j);
            }
        }


        public void MostrarTorneos(string[] losEquipos, ListBox listaT)
        {
            listaT.Items.Clear();
            foreach (string item in losEquipos)
            {
                listaT.Items.Add(item);
            }
        }

    }
}
