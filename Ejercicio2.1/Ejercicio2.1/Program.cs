using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String estado;

            while (true)
            {

            Console.WriteLine(); 
            Console.WriteLine("---Estado civil---");
            Console.WriteLine("Casado (C), Soltero (S), Viudo (V) o Divorciado (D)");
            Console.Write("Ingrese su estado civil, utilizando la letra que lo representa: ");

            estado = Console.ReadLine().ToUpper(); //Uso el ToUpper para evitar problemas al escribir en mayúscula

            //Se controlan los casos en los que el usuario no ingrese nada
            if (string.IsNullOrEmpty(estado))
            {
                Console.WriteLine("El valor ingresado esta vacío");
                
            }

            else if (estado.Length != 1) //Se controla que el usuario no ingrese más de un caracter
            {
                Console.WriteLine("Se han ingresado más de un caracter, le recordamos que solo se debe escribir la letra correspondiente al estado civil");
                
            }


            else
            {
                //Opciones disponibles con  case
                switch (estado)
                {
                    case "C":
                        Console.WriteLine("Tu estado civil es casado");
                        return;

                    case "S":
                        Console.WriteLine("Tu estado civil es soltero");
                        return;

                    case "V":
                        Console.WriteLine("Tu estado civil es viudo");
                        return;

                    case "D":
                        Console.WriteLine("Tu estado civil es divorciado");
                        return;

                    default:
                        Console.WriteLine("El valor ingresado no pertenece a ningún estado"); //En caso de que no corresponda la letra ingresada con las disponibles en los casos
                        break;
                }

            }

            }
        }
    }
}
