using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insertar número: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("El valor absoluto es " + Math.Abs(numero));

            Console.WriteLine("La potencia al cubo es "+ (numero * numero * numero));

            Console.WriteLine("La raiz cuadrada es " + Math.Sqrt(numero));

            Console.WriteLine("El seno es: "+Math.Sin(numero));

            Console.WriteLine("El coseno es: " + Math.Cos(numero));

            Console.Write("Para sacar el número máximo se debe de ingresar otro número para comparar: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El número máximo es: " + Math.Max(numero, numero2));

            Console.Write("Para sacar el número mínimo se debe de ingresar otro número para comparar: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El número mínimo es: " + Math.Min(numero, numero3));

        }
    }
}
