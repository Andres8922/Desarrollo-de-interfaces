using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (char letra = 'z'; letra >= 'a'; letra--)
            {

                if (letra == 'a')
                {
                    Console.Write(letra.ToString().ToUpper()); //Esto lo hago para que la A final no lleve una coma también
                }

                else
                {

                    Console.Write(letra.ToString().ToUpper() + ", ");
                    
                }

            }
        }
    }
}