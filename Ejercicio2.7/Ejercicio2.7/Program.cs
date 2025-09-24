using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el tamaño del array: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] array = new int[tamaño];

            
            Console.WriteLine("Ingrese los elementos del array: ");

                for (int i = 0; i < tamaño; i++){

                    Console.Write("Elemento " +(i + 1)+": ");

                    array[i] = int.Parse(Console.ReadLine()); //Leo el número introducido y lo meto en la posición i del array
                }


           Console.WriteLine("Los números pares e impares son: ");
            for (int j = 0; j < array.Length; j++)
            {
               
                int num = array[j];

                if (num % 2 == 0)
                {
                    Console.WriteLine("El valor "+num + " es par");
                }

                else
                {
                    Console.WriteLine("El valor "+num + " es impar");
                }

            }

        }
    }
}
