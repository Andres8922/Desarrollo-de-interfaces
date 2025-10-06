using System;

namespace Ejercicio_3
{
    public class Cancion
    {
        // Atributos privados
        private string titulo;
        private string autor;

        // Constructor con parámetros
        public Cancion(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        // Constructor por defecto
        public Cancion()
        {
            this.titulo = "";
            this.autor = "";
        }

        // Métodos
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

    // Clase de prueba opcional
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear canción con constructor por defecto
            Cancion c1 = new Cancion();
            c1.ponTitulo("Felices los 4");
            c1.ponAutor("Maluma x Shakira");

            Console.WriteLine("Título: " + c1.dameTitulo());
            Console.WriteLine("Autor: " + c1.dameAutor());

            // Crear canción con constructor con parámetros
            Cancion c2 = new Cancion("Imagine", "John Lennon");

            Console.WriteLine("Título: " + c2.dameTitulo());
            Console.WriteLine("Autor: " + c2.dameAutor());

            
        }
    }
}
