using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nIngresar la nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7.0 && nota < 8.5)
            {
            Console.WriteLine("\nLa calificación obtenida es Buena\n");
            }
            else if (nota >= 8.5 && nota < 9.5)
            {
            Console.WriteLine("\nLa calificación obtenida es Muy Buena\n");
            }
            else if (nota >= 9.5)
            {
            Console.WriteLine("\nLa calificación obtenida es Excelente\n");
            }
            else
            {
            Console.WriteLine("\nLa calificación obtenida es Deficiente\n");
            }
        }
    }
}
