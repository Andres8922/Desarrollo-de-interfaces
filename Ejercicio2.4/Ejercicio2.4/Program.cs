using System;

namespace Ejercicio2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());


            Console.WriteLine("-- Calculando factorial --");

            int fact = 1;

            for (int i = 1; i <= numero; i++)
            {
                fact *= i;
            }

            // Mostrar el cálculo del factorial en forma de multiplicación
            for (int i = numero; i >= 1; i--)
            {
                Console.Write(i);
                if (i > 1)
                {
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write(" = " + fact);
                }
            }

            // Manejo para 0
            if (numero == 0)
            {
                Console.WriteLine("El factorial de 0 es 1");
            }

            
        }
    }
}
