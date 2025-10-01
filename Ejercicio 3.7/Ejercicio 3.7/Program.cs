using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduce un número entero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce otro número entero: ");
            int numero2 = int.Parse(Console.ReadLine());


            Console.WriteLine(new Program().multiplo(numero1, numero2));

        }


        public string multiplo(int numero1, int numero2) {

            String resultado = "";

            if (numero1 == 0 || numero2 == 0) { 
            
                resultado = "No se puede determinar si un número es múltiplo del otro cuando uno de ellos es cero";
                return resultado;
            }

            if (numero1 == numero2) { 
            
                resultado = "Ambos números son iguales, por lo tanto son múltiplos entre sí";
                return resultado;
            }

            if (numero1 % numero2 == 0) { 
            
                resultado = "El número " + numero1 + " es múltiplo de " + numero2;
                return resultado;
            }

            else if (numero2 % numero1 == 0) { 
            
                resultado = "El número " + numero2 + " es múltiplo de " + numero1;
                return resultado;
            }

            else { 
            
                resultado = "Ninguno de los números es múltiplo del otro";
                return resultado;
            }


        }
    }
}
