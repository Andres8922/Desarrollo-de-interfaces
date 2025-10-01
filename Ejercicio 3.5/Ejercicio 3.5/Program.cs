using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Introduzca la bsae: ");
            int basenum = int.Parse(Console.ReadLine());

            Console.Write("Introduzca el exponente: ");
            int expnum = int.Parse(Console.ReadLine());


            int resultado_recursiva = new Program().potenciaRecursiva(basenum, expnum);
            int resultado_iterativa = new Program().potenciaIterativa(basenum, expnum);

            Console.WriteLine("El resultado de la potencia recursiva es: " + resultado_recursiva);
            Console.WriteLine("El resultado de la potencia iterativa es: " + resultado_iterativa);

        }


        public int potenciaRecursiva(int basenum, int expnum)
        {
            int resultado = 0;

            if (expnum == 0)
            {
                return resultado = 1; // Cualquier número elevado a la potencia de 0 es 1
            }

            else
            {
                return resultado = basenum * potenciaRecursiva(basenum, expnum - 1); // Llamada recursiva
            }
        }

        public int potenciaIterativa(int basenum, int expnum)
        {
            
            int resultado = 1; //Para que empieze multiplicando por el primer número base

            for (int i = 0; i < expnum; i++)
            {
                resultado = resultado * basenum;
            }

            return resultado;
        }

    }

}
