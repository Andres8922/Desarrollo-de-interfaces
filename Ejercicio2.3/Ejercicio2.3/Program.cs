using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese una cadena de texto: ");
            string cadena = Console.ReadLine();

            //Longitud de la cadena
            int length = cadena.Length;
            Console.WriteLine("La longitud de la cadena es: " + length);

            //Comprobar si contiene una determinada  subcadena
            if (cadena.Contains("Buenos dias"))
            {
               Console.WriteLine("La cadena contiene 'Buenos dias'");
            }

            else
            {
                Console.WriteLine("La cadena no contiene 'Buenos dias'");
            }


            //Reemplazar una letra por otra
            string replacedString = cadena.Replace('a', 'e');


            //Conversión a mayúsculas
            string mayuscula = cadena.ToUpper();
            Console.WriteLine("Cadena en mayúsculas: " + mayuscula);


            //Conversión a minúsculas
            string minuscula = cadena.ToLower();
            Console.WriteLine("Cadena en minúsculas: " + minuscula);


            //Eliminar algún carácter en una posición determinada
            string eliminarCaracter = cadena.Remove(2, 1); //De la segunda posición elimina 1 carácter
            Console.WriteLine("Cadena sin el carácter en la posición 2: " + eliminarCaracter);

            //Obtener una subcadena indicándole posición inicial y final
            string subcadena = cadena.Substring(2, 8); //Desde la posición 2, toma 8 caracteres
            Console.WriteLine("Subcadena desde la posición 2 con longitud 8: " + subcadena);

        }
    }
}
