using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los digitos es: " + new Program().resultado_sum(numero));

        }


        public int resultado_sum(int numero) {

            int resultado = 0;

            string cadena = numero.ToString(); //Convierto el número en una cadena string

            foreach (char c in cadena) //Hago un foreach para recorrer cada caracter de la cadena y dividiendolo en cacracteres
            { 

                int digito = int.Parse(c.ToString()); //Convierto los caracteres en enteros y los voy sumando abajo

                resultado += digito;
            }

            return resultado;
        
        }
    }
}
