using System;

namespace dispensadordedulces
{
    class Program
    {
        static void Main(string[] args)
        {
            double pago;
            string codigos = "";

            int preciogalleta = 12;
            int preciochocolate = 12;
            int preciopapitas = 12;
            int preciodulcedementa = 12;
            
            Console.WriteLine("los codigos para los productos son los siguientes" +
                "galletas-> 01, papitas ->02 chocolate-> 03 dulces de menta ->04");


            Console.WriteLine("porfavor ingrese un codigo");

            codigos = Console.ReadLine();
            try
            {

                if (codigos == "01")
                {
                    Console.WriteLine("despachando galletas");

                }

                else if (codigos == "02")
                {

                    Console.WriteLine("despachando papitas");
                }
                else if (codigos == "03")
                {

                    Console.WriteLine("despachando chocolate");
                }
                else if (codigos == "04")
                {
                    Console.WriteLine("despachando dulces de menta");

                }
            }

            catch (Exception error)
            {

            }

            Console.ReadKey();
        }
    }
}
