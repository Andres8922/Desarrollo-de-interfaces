using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int intento = 0;

            while (true)
            {
                intento++;

                if (intento > 3)
                {
                    Console.Write("Se ha superado el número de intentos permitido, denegando entrada");
                    break;
                }

                Console.Write("Introduzca el nombre de usuario: ");
                String usuario = Console.ReadLine();

                Console.Write("Introduzca la contraseña: ");
                String contrasena = Console.ReadLine();

               
                if (new Program().comprobacion(usuario, contrasena)) //En caso de ser correcto
                {
                    Console.WriteLine("Acceso correcto");
                    break;
                }

                else
                {
                    Console.WriteLine("Acceso denegado, contraseña o nombre de usuario incorrecto");
                    Console.WriteLine("Numero de intento "+intento);
                }

            }

        }
        


        public bool comprobacion(String usuario, String contraseña) {

            if (usuario == "usuario2DAM" && contraseña == "pass2DAM")
            {
                return true;
            }


            return false;
        
        }
    }
}
