using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la cantidad de dicho producto: ");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            double total = precio * cantidad;

            Console.WriteLine($"El total a pagar es: {total}");

        }
    }
}
