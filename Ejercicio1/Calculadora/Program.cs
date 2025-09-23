using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(); //Salto de línea 
            Console.WriteLine("--Menú de operaciones matemáticas--");
            Console.WriteLine();

            Console.WriteLine("Operaciones disponibles:");
            Console.WriteLine();

            //Opciones del menú
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Máximo de dos números");
            Console.WriteLine("6. Mínimo de dos números");
            Console.WriteLine("7. Raíz cuadrada de un número");
            Console.WriteLine("8. Valor absoluto de un número");
            Console.WriteLine("9. Redondea un número al valor más cercano");
            Console.WriteLine();

            //Mientras se cumpla la condición, el menú se repetirá
            while (true)
            {

                Console.WriteLine("Elige una operación (1-9) o escriba 0 para salir del menú: ");
                int operacion = Convert.ToInt32(Console.ReadLine());

                if (operacion  < 0 || operacion > 9)
                {
                    Console.WriteLine("Se ha elegido una operación inexistente");
                    Console.WriteLine(); //Salto de línea
                }

                if (operacion == 0)
                {
                    Console.WriteLine("Saliendo del menú");
                    break;
                    
                }

                switch (operacion)
                {

                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido sumar. Introduce el primer número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        double resultado = num1 + num2;
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        Console.WriteLine();
                        break;


                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido restar. Introduce el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        resultado = num1 - num2;
                        Console.WriteLine("El resultado de la resta es: " + resultado);
                        Console.WriteLine();
                        break;


                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido multiplicar. Introduce el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        resultado = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                        Console.WriteLine();
                        break;


                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido dividir. Introduce el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        if (num1 == 0)
                        {
                            Console.WriteLine("No se puede dividir entre cero");
                            break;
                        }

                        Console.WriteLine("Introduce el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir entre cero");
                            break;
                        }

                        resultado = num1 / num2;
                        Console.WriteLine("El resultado de la división es: " + resultado);
                        Console.WriteLine();
                        break;


                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido indicar el número máximo. Introduce el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        resultado = Math.Max(num1, num2);
                        Console.WriteLine("El número máximo es: " + resultado);
                        Console.WriteLine();
                        break;


                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido indicar el número mínimo. Introduce el primer número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduce el segundo número: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        resultado = Math.Min(num1, num2);
                        Console.WriteLine("El número mínimo es: " + resultado);
                        Console.WriteLine();
                        break;


                    case 7:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido calcular la raíz cuadrada. Introduce el número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        resultado = Math.Sqrt(num1);
                        Console.WriteLine("La raíz cuadrada es: " + resultado);
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido calcular el valor absoluto. Introduce el número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        resultado = Math.Abs(num1);
                        Console.WriteLine("El valor absoluto es: " + resultado);
                        Console.WriteLine();
                        break;

                    case 9:
                        Console.WriteLine();
                        Console.WriteLine("Has elegido redondear un número. Introduce el número: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        resultado = Math.Round(num1);
                        Console.WriteLine("El número redondeado es: " + resultado);
                        Console.WriteLine();
                        break;
                }

            }

        }
    }
}
