using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese una cadena de texto: ");
            String cadena = Console.ReadLine();

            int contador = 0;

            for (int i = 0; i < cadena.Length; i++)
            {

                if (cadena[i] == ' ')
                {
                    contador++;
                }

            }

            Console.WriteLine("El número de espacios es " + contador);

           
            String respuesta = new Program().numero_caracteres(cadena);

            Console.WriteLine(respuesta);

        }

        public string numero_caracteres(string cadena)
        {

            int contador = 0;

            for (int i = 0; i < cadena.Length; i++)
            {

                contador++;

                if (cadena[i] == ' ')
                {
                    contador--;
                }

            }

            String salida = "El número de caracteres es " + contador;

           
            return salida;
        }
    }
}
