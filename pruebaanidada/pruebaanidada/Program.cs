using System;

namespace pruebaanidada
{
    class Program
    {
        static void Main(string[] args)
        {
			string sergiodice = "porfavor dejeme unirme ";
			Console.WriteLine(sergiodice);

			string respuesta;
			respuesta = Console.ReadLine();
			Console.WriteLine(sergiodice);
			
				Console.WriteLine(sergiodice);

			
				

					while (respuesta == "No" || respuesta == "no" || respuesta == "NO" || respuesta == "nO" || respuesta == "")
					{

						Console.WriteLine(sergiodice);
				respuesta = Console.ReadLine();
						if (respuesta == "si" || respuesta == "Si" || respuesta == "SI" || respuesta == "sI")
						{
							sergiodice = "gracias";
							Console.WriteLine(sergiodice);

						}
						
					}
				





			
			Console.ReadKey();
		}
    }
}
