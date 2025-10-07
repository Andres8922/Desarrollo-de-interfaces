public class Program
{

    public class Empleado
    {

        private string nombre;
        private double numHorasExtra;
        private double salarioSinExtras;

        public Empleado(string nombre, double salarioSinExtras)
        {
            this.nombre = nombre;
            this.salarioSinExtras = salarioSinExtras;
            this.numHorasExtra = 0;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public double GetNumHorasExtra()
        {
            return numHorasExtra;
        }

        public double GetSalarioSinExtras()
        {
            return salarioSinExtras;
        }


        public void HacerHorasExtra(int horas_extras)
        {
            numHorasExtra += horas_extras;
        }


        public double CalclarSalarioTotal() {
        
            double salarioTotal = salarioSinExtras + (25 * numHorasExtra);

            return salarioTotal;

        }

    }





    public static void Main(string[] args)
    {

        List<Empleado> empleados = new List<Empleado>(); //Array para guardar los empleados

        Empleado empleado1 = new Empleado("Andres", 1000);
        empleado1.HacerHorasExtra(5);

        Empleado empleado2 = new Empleado("Paula", 1200);
        empleado2.HacerHorasExtra(8);

        Empleado empleado3 = new Empleado("Abel", 1500);

        empleados.Add(empleado1);
        empleados.Add(empleado2);
        empleados.Add(empleado3);


        Console.WriteLine("******************Bienvenidos a OsunaTech S.L.******************");

        Console.WriteLine("ADMINISTRACIÓN");

        Console.WriteLine("1) Dar alta nuevo empleado");
        Console.WriteLine("2) Calcular horas extra totales de todos los empleados");
        Console.WriteLine("3) Mostrar informe de todos los empleados");

        Console.WriteLine("EMPLEADOS");

        Console.WriteLine("4) Insertar hora extra");
        Console.WriteLine("****************************************************************");


        Console.Write("Seleccione el número de la acción que desee realizar: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion > 4 || opcion < 1)
        {
            Console.WriteLine("No se ha seleccionado una opcion existente");
        }

        else
        {
            if (opcion > 0 && opcion < 4)
            {
                Console.WriteLine("Se ha seleccionado una opción de administrador, porfavor ingrese la contraseña de admin para poder usarla: ");
                string contraseña = Console.ReadLine();

                if (contraseña == "admin123")
                {
                    Console.WriteLine("Contraseña correcta");

                    switch (opcion)
                    {

                        case 1: //Dar alta nuevo empleado

                            Console.Write("Ingrese el nombre del empleado: ");
                            string nombre_empleado = Console.ReadLine();

                            Console.Write("Ingrese el salario sin extras del empleado: ");
                            double salario_empleado = double.Parse(Console.ReadLine());

                            Empleado nuevo_empleado = new Empleado(nombre_empleado, salario_empleado);

                            empleados.Add(nuevo_empleado);

                            Console.WriteLine("La posición del nuevo empleado en la lista es: "+empleados.Count+ "º");

                            break;


                        case 2: //Calcular horas extra totales de todos los empleados

                            double total_horas = 0;

                            foreach (Empleado em in empleados)
                            {
                                Console.WriteLine("El empleado " + em.GetNombre() + " ha realizado un total de " + em.GetNumHorasExtra() + " horas extra");

                                total_horas += em.GetNumHorasExtra();
                            }

                            Console.WriteLine("El total de horas extra realizadas por todos los empleados es: " + total_horas);

                            break;


                        case 3: //Mostrar informe de todos los empleados

                            Console.WriteLine("INFORME DE EMPLEADOS");

                            foreach (Empleado em in empleados)
                            {
                                Console.WriteLine("Empleado: " + em.GetNombre());
                                Console.WriteLine("Salario sin extras: " + em.GetSalarioSinExtras() + " euros");
                                Console.WriteLine("Horas extra realizadas: " + em.GetNumHorasExtra());
                                Console.WriteLine("Salario total (con extras): " + em.CalclarSalarioTotal() + " euros");
                                Console.WriteLine("---------------------------------------------------");
                            }

                            break;

                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }

                }

                else
                {
                    Console.WriteLine("Contraseña incorrecta, no se puede acceder a las opciones de administrador");
                }
            }

            else
            {
                
                //Insertar hora extra

                Console.Write("Ingrese el nombre de empleado: ");
                string nombre_empleado = Console.ReadLine();

                Boolean encontrado = false;

                foreach (Empleado em in empleados)
                {

                    String comparador = em.GetNombre();

                    if (comparador == nombre_empleado)
                    {
                        Console.Write("Empleado encontrado, ingrese el número de horas extra realizadas: ");
                        int extras = int.Parse(Console.ReadLine());

                        em.HacerHorasExtra(extras);
                        Console.WriteLine("Horas extra añadidas correctamente");
                        Console.WriteLine("El empleado " + em.GetNombre() + " ha realizado un total de " + em.GetNumHorasExtra() + " horas extra");

                        encontrado = true;
                    }

                   
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Empleado no encontrado");

                }
        }



    }


    }
}
