using System;

namespace Ejercicio_4_2
{
    internal class Program
    {
        public class Contacto
        {
            private string nombre;
            private int telefono;

            public Contacto(string nombre, int telefono) { 
            
                this.nombre = nombre;
                this.telefono = telefono;

            }

            public string Nombre { get => nombre; set => nombre = value; }
            public int Telefono { get => telefono; set => telefono = value; }
        }

        public class Agenda_contactos
        {
            private Contacto[] contactos;

            public Agenda_contactos(int num_contactos = 10)
            {
                contactos = new Contacto[num_contactos];
            }

            public void añadir_contacto(Contacto contacto)
            {
                // Verificar si el contacto ya existe
                foreach (var c in contactos)
                {
                    if (c != null && c.Nombre == contacto.Nombre)
                    {
                        Console.WriteLine("El contacto ya existe.");
                        return;
                    }
                }

                // Añadir contacto en el primer hueco libre
                for (int i = 0; i < contactos.Length; i++)
                {
                    if (contactos[i] == null)
                    {
                        contactos[i] = contacto;
                        Console.WriteLine("Contacto añadido.");
                        return;
                    }
                }

                Console.WriteLine("Límite de contactos alcanzado.");
            }

            public string existe_contacto(string nombre)
            {
                foreach (var c in contactos)
                {
                    if (c != null && c.Nombre == nombre)
                    {
                        return "El contacto existe.";
                    }
                }

                return "El contacto no existe.";
            }

            public string listar_contactos()
            {
                string lista = "";
                foreach (var c in contactos)
                {
                    if (c != null)
                    {
                        lista += $"{c.Nombre} - {c.Telefono}\n";
                    }
                }

                return string.IsNullOrEmpty(lista) ? "No hay contactos en la agenda." : lista;
            }

            public string buscarContactos(string nombre)
            {
                foreach (var c in contactos)
                {
                    if (c != null && c.Nombre.Contains(nombre))
                    {
                        return $"Número de {c.Nombre}: {c.Telefono}";
                    }
                }

                return "No existe el contacto indicado.";
            }

            public void eliminar_contacto(string nombre)
            {
                for (int i = 0; i < contactos.Length; i++)
                {
                    if (contactos[i] != null && contactos[i].Nombre == nombre)
                    {
                        contactos[i] = null;
                        Console.WriteLine("Contacto eliminado.");
                        return;
                    }
                }

                Console.WriteLine("No existe el contacto indicado.");
            }

            public string agenda_llena()
            {
                foreach (var c in contactos)
                {
                    if (c == null)
                        return "La agenda aún tiene espacio.";
                }

                return "La agenda está llena.";
            }

            public string huecos_Libres()
            {
                int huecos = 0;

                foreach (var c in contactos)
                {
                    if (c == null)
                        huecos++;
                }

                return $"Quedan {huecos} huecos libres.";
            }
        }

        static void Main(string[] args)
        {
            Agenda_contactos agenda = new Agenda_contactos();

            Contacto contacto1 = new Contacto("Paula", 123456789);

            Contacto contacto2 = new Contacto("Andres", 987654321);

            agenda.añadir_contacto(contacto1);
            agenda.añadir_contacto(contacto2);

            Console.WriteLine("\nLista de contactos:");
            Console.WriteLine(agenda.listar_contactos());

            Console.WriteLine(agenda.existe_contacto("Andres"));
            Console.WriteLine(agenda.existe_contacto("Manuel"));

            Console.WriteLine(agenda.buscarContactos("Paula"));

            agenda.eliminar_contacto("Paula");

            Console.WriteLine("\nLista actualizada:");
            Console.WriteLine(agenda.listar_contactos());

            Console.WriteLine(agenda.agenda_llena());

            Console.WriteLine(agenda.huecos_Libres());

           
        }
    }
}
