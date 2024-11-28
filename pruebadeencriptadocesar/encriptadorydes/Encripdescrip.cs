using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;

namespace encriptadorydes
{
    public class Encripdescrip
    {

        int letras = 0;

        char[] ch;
        ListBox lista;
        string mensaje = "";
        public string encriptador(string palabra,ListBox lista,ref string mensaje)
        {

            int numpos=0;

            string guardar;
            
            string cadenas=palabra;
            letras = cadenas.Length;
            ch = new char[letras];
            char pal;
            int i ;
            for (i = 0; i < letras; i++)
            {
                numpos = (int)cadenas[i];
                ch[i] = (char)(numpos + 3);
                lista.Items.Add(ch[i]);
                guardar = new string (ch);
                //foreach ( var g in ch)
                //     guardar = g.ToString();
                
             //  guardar = Convert.ToString(ch[i]);
              // guardar = Convert.ToString(pal);
                palabra = guardar;
            }

            MessageBox.Show(palabra);
           
          


            return mensaje;
        }


        public string encriptador2(string palabra, ListBox lista, int numeros,ref string mensaje)
        {

            int numpos = 0;
           

            string cadenas = palabra;
            letras = cadenas.Length;
            numeros = (numeros % 26 + 26) % 26;
          
            ch = new char[letras];

            if (numeros>0 ) {
                for (int i = 0; i < letras; i++)
                {
                    numpos = (int)cadenas[i];
                    ch[i] = (char)(numpos + numeros );
                    lista.Items.Add(ch[i]);
                }

            }

            return mensaje;
        }




        public string desencriptador(string palabra,ListBox lista,ref string mensaje)
        {
            int numpos = 0;


            string cadenas = palabra;
            letras = cadenas.Length;
            ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                numpos = (int)cadenas[i];
                ch[i] = (char)(numpos - 3);
                lista.Items.Add(ch[i]);
            }

            return mensaje;
        }
       

    }
}
