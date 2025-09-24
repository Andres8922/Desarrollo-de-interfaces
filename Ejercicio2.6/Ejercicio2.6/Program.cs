using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();

            int numero = random.Next(10, 31);

            Console.WriteLine("Número generado: "+ numero);

            }

        }
    }

