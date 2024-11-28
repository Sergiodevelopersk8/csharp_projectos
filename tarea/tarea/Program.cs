using System;

namespace tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea");

            int opcion =0;
            int edad=0;
            bool bucle=true;

          
          
            while (bucle) {
                Console.WriteLine("porfavor seleccione una opción");
                Console.WriteLine("opcion 1 saber si eres mayor de edad \n opcion 2 ingresar e imprimir estrellas\n  opcion 3 finalizar el programa\n)");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                     
                    case 1:

                        Console.WriteLine("porfavor ingrese su edad para saber si es mayor de edad\n");
                        edad = int.Parse(Console.ReadLine());
                        if (edad >= 18)
                        {
                            Console.WriteLine("ya eres mayor de edad");

                        }
                        else
                        {
                            Console.WriteLine("Todavia eres menor de edad");
                        }
                        break;


                    case 2:
                      
                        for(int i=1; i <=5; i++)
                        {
                            int asterisco = 0;
                            Console.WriteLine("\ningrese " +" " + i +" "+  "numero entero:\n");
                            asterisco = int.Parse(Console.ReadLine());
                            for(int j = 1; j <= asterisco; j++)
                            {
                                Console.Write("*\n");
                            }
                           
                        }


                        break;

                    case 3:

                        Console.WriteLine("finalizara el programa");
                        bucle = false;
                        break;
                }
            }
            

            Console.ReadKey();
        }
    }
}
