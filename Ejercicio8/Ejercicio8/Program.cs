using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--Ingrese las nota que se le pedirá a continuación--");

            Console.Write("Ingresar las primera nota del examen: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresar las segunda nota del examen: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double promedio = (nota1 + nota2) / 2;

            Console.Write("Ingrese la nota del trabajo e clase: ");
            double notaTrabajo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese su nota de actitud en clase: ");
            double notaActitud = Convert.ToDouble(Console.ReadLine());


            double calificacionFinal = (promedio * 0.5) + (notaTrabajo * 0.3) + (notaActitud * 0.2);

            Console.Write($"Su calificación final es {calificacionFinal}");

        }
    }
}
