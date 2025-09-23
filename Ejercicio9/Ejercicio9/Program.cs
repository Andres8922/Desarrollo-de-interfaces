using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un string: ");
            String string_ingresado = Console.ReadLine();

            Boolean cierto = false;

            if (string_ingresado.StartsWith("www") || string_ingresado.StartsWith("WWW"))
            {
                cierto = true;
            }

            Console.WriteLine(cierto);

        }
    }
}
