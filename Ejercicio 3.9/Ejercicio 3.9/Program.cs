using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = {1,2,6,8,12};


            Console.Write("El número más pequeño del array es: " + (new Program().menor(array)));

           
        }

        int menor(int[] array)
        {

            int comparador = array[0];

            foreach (int numero in array)
            {

                if (numero < comparador)
                {
                    comparador = numero;
                }

            }

            return comparador;
        }

    }
}
