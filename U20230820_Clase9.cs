﻿using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)

        {
            //EJERCICIO DE CLASE 9.

            //PROGRAMA PARA EVALUAR CALIFICACIONES.
            Console.WriteLine("\n---------EVALUAR LA CALIFICACION---------\n");
            Console.Write("\nIngresar la nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            //Si la nota es igual o mayor que 7, y si es menor que 8.5
            if (nota >= 7.0 && nota < 8.5)
            {
            Console.WriteLine("\nLa calificación obtenida es Buena\n");
            }

            //Si la nota es igual o mayor que 8.5, y si es menor que 9.5
            else if (nota >= 8.5 && nota < 9.5)
            {
            Console.WriteLine("\nLa calificación obtenida es Muy Buena\n");
            }

            //Si la nota es mayor o igual que 9.5
            else if (nota >= 9.5)
            {
            Console.WriteLine("\nLa calificación obtenida es Excelente\n");
            }
            else
            {
            //Si no cumple con las condiciones requeridas
            Console.WriteLine("\nLa calificación obtenida es Deficiente\n");
            }
             Console.WriteLine("\n----------FIN LA CALIFICACION----------\n");

        }
    }
}