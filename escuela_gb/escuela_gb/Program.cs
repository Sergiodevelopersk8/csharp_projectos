using System;

namespace escuela_gb
{
    class Program
    {
        static void Main(string[] args)
        {

           


            double disco = 1024;
            double lleno = 0;
            double variable1;
            double variable2;
   

            bool ciclo = false;
            Console.WriteLine("Disco");
            while (ciclo == false)
            {
                Console.WriteLine("inserte primera cantidad");
                variable1 = double.Parse(Console.ReadLine()); 
                Console.WriteLine("inserte segunda cantidad");
                variable2 = double.Parse(Console.ReadLine());

                if(variable1 > variable2)
                {
                    lleno = lleno + variable1 ;
                    Console.WriteLine(" cantidad 1 "+ " "+ lleno);

                }

                else if (variable2 > variable1)
                {
                    lleno = lleno + variable2;
                    Console.WriteLine(" cantidad 2 " + " "+ variable2);
                }

                if(lleno == disco)
                {
                    Console.WriteLine("disco lleno");
                    ciclo = true;
                }

            }

            Console.ReadKey();

        }
    }
}
