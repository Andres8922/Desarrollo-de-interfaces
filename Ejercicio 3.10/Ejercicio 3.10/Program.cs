using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._10
{
    internal class Program
    {
        private class Cliente
        {


            private string nombre;
            private double cantidadTotal;


            public Cliente(string nombre)
            {

                this.nombre = nombre;
                cantidadTotal = 0;

            }

            //Getters y Setters
            public string GetNombre()
            {
                return nombre;
            }
            public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }
            public double GetCantidadTotal()
            {
                return cantidadTotal;
            }
            public void SetCantidadTotal(double cantidadTotal)
            {
                this.cantidadTotal = cantidadTotal;
            }

            public void Ingresar(double ingresar)
            {


                if (ingresar <= 0)
                {
                    Console.WriteLine("Valor inválido para realizar el ingreso");
                }

                else
                {
                    cantidadTotal += ingresar;
                }


            }


            public void Sacar(double retirar)
            {



                if (cantidadTotal <= 0 || retirar > cantidadTotal)
                {
                    Console.WriteLine("Fondos insuficientes");
                }

                else
                {
                    cantidadTotal -= retirar;
                }

            }


            public void MostrarInformacion()
            {
                Console.WriteLine("Nombre del cliente: " + GetNombre());
                Console.WriteLine("Cantidad total en la cuenta: " + GetCantidadTotal());
            }




            private class Banco
            {  //Main

                static void Main(string[] args)
                {                    
                    Banco banco = new Banco();

                    banco.Operar();

                    banco.ObtenerEstado();
                }

                Cliente cliente1 = new Cliente("Andres");
                Cliente cliente2 = new Cliente("Paula");
                Cliente cliente3 = new Cliente("Abel");


                public void Operar()
                {

                    cliente1.Ingresar(1000);

                    cliente2.Ingresar(1000);

                    cliente3.Ingresar(3000);

                }


                public void ObtenerEstado()
                {

                    double suma = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();

                    Console.WriteLine("Cantidad ingresada por todos: " + suma);

                    Console.WriteLine("Cantidad ingresada por Andres: " + cliente1.GetCantidadTotal());

                    Console.WriteLine("Cantidad ingresada por Paula: " + cliente2.GetCantidadTotal());

                    Console.WriteLine("Cantidad ingresada por Abel: " + cliente3.GetCantidadTotal());

                }

                
            }


        }
    }

}
    
    

