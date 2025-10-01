using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduzca el tamaño del array a crear: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] array = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Introduzca el valor de la posición " + (i+1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {

                int valor = array[i];

                suma += valor;
              
            }

            double media = (double)suma / array.Length;

            Console.WriteLine("La suma de los valores introducidos es: " + suma);
            Console.WriteLine("La media de los valores introducidos es: " + media);

        }
    }
}
