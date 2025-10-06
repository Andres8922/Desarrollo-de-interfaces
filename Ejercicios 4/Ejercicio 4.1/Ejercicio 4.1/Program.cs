using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4._1
{
    internal class Program
    {
        public class Cuenta
        {
            private string titular;

            private double cantidad;


            public Cuenta(string titular, double cantidad = 0)
            {
                this.titular = titular;

                this.cantidad = cantidad; //Si no se le mete por pantalla al crear la cuenta será 0 porque no es obigatorio
            }


            //Getters y Setters
            public string Titular
            {
                get { return titular; }
                set { titular = value; }
            }

            public double Cantidad
            {
                get { return cantidad; }
                set { cantidad = value; }
            }


            //ToString

            public override string ToString()
            {
                return "Titular: " + titular + ", Cantidad: " + cantidad;
            }


            //Métodos   

            public void ingresar(double cantidad)
            {
                if (cantidad > 0)
                {
                    this.cantidad += cantidad;
                }

                else
                {
                    return;
                }
            }


            public void retirar(double cantidad)
            {
                this.cantidad -= cantidad;

                if (this.cantidad < 0)
                {
                    this.cantidad = 0;
                }
            }


            public static void Main(string[] args)
            {
                Cuenta cuenta1 = new Cuenta("Andres", 1000);
                Console.WriteLine(cuenta1.ToString());
                cuenta1.ingresar(500);
                Console.WriteLine("Después de ingresar 500: " + cuenta1.ToString());
                cuenta1.retirar(2000);
                Console.WriteLine("Después de retirar 2000: " + cuenta1.ToString());
                cuenta1.retirar(300);
                Console.WriteLine("Después de retirar 300: " + cuenta1.ToString());

            }
        }

    }
}
