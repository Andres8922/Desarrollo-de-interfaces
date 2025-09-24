using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }

            Console.WriteLine("Array generado: ");

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            //Ordeno el array y lo muestro
            Console.WriteLine("Array ordenado: ");

            Array.Sort(array);

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }


        }
    }
}
