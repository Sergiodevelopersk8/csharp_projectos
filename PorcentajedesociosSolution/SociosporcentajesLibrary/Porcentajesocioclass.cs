using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace SociosporcentajesLibrary
{
    public class Porcentajesocioclass
    {

        double monto1, monto2, monto3;
        double capital=0.0;
        double[] arreglo = new double[3];
        string[] socios = new string[3];
        string[] espacio = new string[2];
        
        double psocio1;
        double psocio2;
        double psocio3;


        public void porcentajedelossocios()
        {

            for (int i = 0; i < 3; i++)
            {
                arreglo[i] = double.Parse(Interaction.InputBox("agregar monto del socio" ));

                monto1 = arreglo[0];
                monto2 = arreglo[1];
                monto3 = arreglo[2];
               

            }

            capital = monto1 + monto2 + monto3;

            psocio1 = (monto1 * 100) / capital;
            psocio2 = (monto2 * 100) / capital;
            psocio3 = (monto3 * 100) / capital;
          


        }

        public void imprimir(ListBox lista)
        {
            socios[0] = " porcentaje del socio1";
            socios[1] = "porcentaje del socio2";
            socios[2] = "porcentaje del socio3";
            espacio[0] = " ";
            espacio[1] = "capital total ";

           // lista.Items.Add(espacio[1]);
            lista.Items.Add("el capital es  "+" = " + capital);
           //// lista.Items.Add(espacio[0]);
           // lista.Items.Add(" porcentaje del socio1" + " = "+ socios[0]);
            lista.Items.Add(" porcentaje del socio1" + " = " + psocio1);
            //lista.Items.Add(espacio[0]);
            //lista.Items.Add(socios[1]);
            lista.Items.Add(" porcentaje del socio2" + " = " + psocio2);
            /*lista.Items.Add(espacio[0]);
            lista.Items.Add(socios[2]);*/
            lista.Items.Add(" porcentaje del socio3" + " = " + psocio3);
         

        }

    }
}
