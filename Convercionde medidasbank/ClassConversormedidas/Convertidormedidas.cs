using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassConversormedidas
{
    public class Convertidormedidas
    {

        public double metros;
        public double centimetros;
        public double pulgadas;
        public double pies;
        public double yardas;


        //public void operacionesconv(string metross/*, string centimetross, string pulgadass, string piess, string yardass*/)
        //{
        //    metros = double.Parse(metross);
        //    //centimetros = double.Parse(centimetross);
        //    //pulgadas = double.Parse(pulgadass);
        //    //metros = double.Parse(metross);
        //    //pies = double.Parse(piess);
        //    //yardas = double.Parse(yardass);




        //}

        public void operacionesconv(string metross) 
        { 
            metros = double.Parse(metross);
            try
            {

                centimetros = metros * 100.0;
                pulgadas = centimetros / 2.54;
                pies = pulgadas / 12.0;
                yardas = pies / 3.0;

            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            
            }

        }

        public void generar(ListBox lista)
        {
            lista.Items.Clear();

            string[] medidas = new string[5];
            medidas[0] = "Centimetros";
            medidas[1] = "Pulgadas";
            medidas[2] = "Pies";
            medidas[3] = "Yardas";
            medidas[4] = " ";

            lista.Items.Add(medidas[0]);
            lista.Items.Add(centimetros);
            lista.Items.Add(medidas[4]);
            lista.Items.Add(medidas[1]);
            lista.Items.Add(pulgadas);
            lista.Items.Add(medidas[4]);
            lista.Items.Add(medidas[2]);
            lista.Items.Add(pies);
            lista.Items.Add(medidas[4]);
            lista.Items.Add(medidas[3]);
            lista.Items.Add(yardas);

        }


       
      
    }
}
