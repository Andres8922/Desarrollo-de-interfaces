using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());


            if (primo(numero))
            {
                Console.WriteLine("El número " + numero + " es primo");
            }
            else
            {
                Console.WriteLine("El número " + numero + " no es primo");
            }


        }


        public static bool primo(int numero)
        {
            if (numero <= 1) return false; //Los numeros iguales o menores que 1 no son primos
            if (numero == 2) return true; //El único número par es el 2


            for (int i = 2; i <= Math.Sqrt(numero); i++) //El math.sqrt se utiliza para calcular la raiz cuadrada del numero 
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }

}
