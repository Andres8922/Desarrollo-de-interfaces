using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            double num4 = Convert.ToDouble(Console.ReadLine());


            double suma = num1 + num2;

            double producto = num3 * num4;

            Console.WriteLine($"La suma del primer y segundo número es: {suma}, mientras que el producto del tercer y cuarto número es {producto}");

        }
    }
}
