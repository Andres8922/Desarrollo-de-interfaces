using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;

            while (true)
            {


                Console.Write("Ingrese un numero del 1 al 9: ");

                numero = int.Parse(Console.ReadLine());

                if (numero < 1 || numero > 9) //En caso de ingresar un número erroneo
                {

                    Console.WriteLine("El numero ingresado no es valido.");

                }

                else { break; }

            }

                Console.WriteLine("Tabla de multiplicar del " + numero + ":");

                for (int i = 1; i <= 10; i++) //La tabla será del 1 al 10
                {
                    Console.WriteLine(numero + " x " + i + " = " + (numero * i));


                }
          
        }
    }
}
