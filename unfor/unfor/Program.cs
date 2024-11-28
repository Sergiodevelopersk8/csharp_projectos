using System;

namespace unfor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "enero", "febrero","marzo","abril"};

            string buscar = "";

            Console.WriteLine("ingresa un mes ");
            buscar = Console.ReadLine();
            if(buscar!=" ")
            {


                for (int i = 0; i < meses.Length; i++)
                {

                    if (meses[i] == buscar)
                    {

                        Console.WriteLine("el mes que buscas es" + " " + meses[i]);

                    }


                }

            }
            Console.ReadKey();

           



        }
    }
}
