using System;
using System.Collections.Generic;

namespace usode_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVolador> patos = new List<IVolador>();
            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();
            patos.Add(pato1);
            patos.Add(pato2);
            patos.Add(pato3);
            AVolar(patos);
        }
     static   void AVolar(List<IVolador> aves)
        {
            foreach (var ave in aves)
            {
                ave.Vuela();
            }

        }

        /*esta si es una interfaz*/
        interface IVolador
        {
            public void Vuela();
        }

        interface ICaminador
        {
          public  void Caminar();
        }


        public class Pato : IVolador, ICaminador
        {
            public void Vuela()
            {
                Console.WriteLine("pato vuela");
            }

            public void Caminar()
            {
                Console.WriteLine("pato camina");
            }


        }
    }
}
