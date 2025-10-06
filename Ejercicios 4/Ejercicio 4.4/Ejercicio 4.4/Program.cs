using System;

namespace Ejercicio_4
{
    public class Cancion
    {
        private string titulo;
        private string autor;

        public Cancion(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public Cancion()
        {
            this.titulo = "";
            this.autor = "";
        }

        public string dameTitulo()
        {
            return titulo;
        }

        public string dameAutor()
        {
            return autor;
        }

        public void ponTitulo(string nuevoTitulo)
        {
            titulo = nuevoTitulo;
        }

        public void ponAutor(string nuevoAutor)
        {
            autor = nuevoAutor;
        }
    }

    public class CD
    {
        private Cancion[] canciones;
        private int contador;

        public CD()
        {
            canciones = new Cancion[100]; // Capacidad máxima de 100 canciones porque no aparece explicito en el enunciado
            contador = 0;
        }

        // Devuelve el número de canciones en el CD
        public int numeroCanciones()
        {
            return contador;
        }

        // Devuelve la canción en una posición dada
        public Cancion dameCancion(int posicion)
        {
            if (posicion >= 0 && posicion < contador)
            {
                return canciones[posicion];
            }
            else
            {
                Console.WriteLine("Posición inválida.");
                return null;
            }
        }

        // Cambia la canción en una posición dada por otra
        public void grabaCancion(int posicion, Cancion nuevaCancion)
        {
            if (posicion >= 0 && posicion < contador)
            {
                canciones[posicion] = nuevaCancion;
            }
            else
            {
                Console.WriteLine("Posición inválida para grabar.");
            }
        }

        // Agrega una canción al final del array
        public void agrega(Cancion nuevaCancion)
        {
            if (contador < canciones.Length)
            {
                canciones[contador] = nuevaCancion;
                contador++;
            }
            else
            {
                Console.WriteLine("El CD está lleno. No se puede agregar más canciones.");
            }
        }

        // Elimina la canción en la posición indicada y reorganiza el array
        public void elimina(int posicion)
        {
            if (posicion >= 0 && posicion < contador)
            {
                for (int i = posicion; i < contador - 1; i++)
                {
                    canciones[i] = canciones[i + 1];
                }

                canciones[contador - 1] = null;
                contador--;
            }
            else
            {
                Console.WriteLine("Posición inválida para eliminar.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CD miCD = new CD();

            Cancion c1 = new Cancion("Buleria", "David Bisbal");
            Cancion c2 = new Cancion("Thriller", "Michael Jackson");
            Cancion c3 = new Cancion("Camisa Negra", "Camaron");

            miCD.agrega(c1);
            miCD.agrega(c2);
            miCD.agrega(c3);

            Console.WriteLine("Canciones en el CD: " + miCD.numeroCanciones());

            Console.WriteLine("Canción en posición 1: " + miCD.dameCancion(1)?.dameTitulo());

            Cancion nueva = new Cancion("Imagine", "John Lennon");
            miCD.grabaCancion(1, nueva);
            Console.WriteLine("Después de grabar nueva canción en posición 1:");
            Console.WriteLine("Canción en posición 1: " + miCD.dameCancion(1)?.dameTitulo());

            miCD.elimina(0);
            Console.WriteLine("Después de eliminar canción en posición 0:");
            for (int i = 0; i < miCD.numeroCanciones(); i++)
            {
                Console.WriteLine($"[{i}] {miCD.dameCancion(i).dameTitulo()} - {miCD.dameCancion(i).dameAutor()}");
            }
                       
        }
    }
}
