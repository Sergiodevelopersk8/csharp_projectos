using System;

namespace ejercisioalfombra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empresa de la alfombra");
            Console.WriteLine("Ingresa la medida del largo para su alfombra");
            float largo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el ancho su alfombra");
            float ancho = float.Parse(Console.ReadLine());
            float areaTotal = 0.0f;
            areaTotal = (largo * ancho);
            Console.WriteLine("La medida total de su alfombra (área) es de: " + areaTotal + "m^2\n");
            Console.WriteLine("¡Personalice los colores de su alfombra");
            Console.WriteLine("Ingres la medida del largo del primer cuadro de color (m):");
            float largo1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingres la medida del ancho del primer cuadro de color (m)");
            float ancho1 = float.Parse(Console.ReadLine());
            if (largo1 < largo && ancho1 < ancho)
            {
                float area1 = 0.0f;
                area1 = (largo1 * ancho1);
                float porcentaje1 = ((area1 * 100) / areaTotal);
                Console.WriteLine("El área del primer cuadrado de color es de :" + area1 + 
                    "m^2. El cual abarca un " + porcentaje1 + "% del total de su alfombra");

            }
            else
            {

                Console.WriteLine("Al parecer se genero un error por favor intentelo de nuevo ");
            }

            Console.WriteLine("Ingres la medida del largo del segundo cuadro de color (m)");
            float largo2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingres la medida del ancho del segundo cuadro de color (m)");
            float ancho2 = float.Parse(Console.ReadLine());
            if (largo2 < largo1 && ancho2 < ancho1)
            {
                float area2 = 0.0f;
                area2 = (largo2 * ancho2);
                float porcentaje2 = 0.0f;
                porcentaje2 = ((area2 * 100) / areaTotal);
Console.WriteLine("El área del segundo cuadrado de color es de :" + area2 + 
    "m^2. El cual abarca un " + porcentaje2 + "% del total de su alfombra");

            }
            else
            {

                Console.WriteLine("Al parecer se genero un error por favor intentelo de nuevo ");
            }

        }
    }
}
