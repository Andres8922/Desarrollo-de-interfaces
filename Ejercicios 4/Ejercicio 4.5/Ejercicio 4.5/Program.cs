using System;

namespace Ejercicio_5
{
    public class Juego
    {
        // Atributo público
        public int vidas;

        // Constructor
        public Juego(int vidasIniciales)
        {
            vidas = vidasIniciales;
        }

        // Método para mostrar vidas restantes
        public void MuestraVidasRestantes()
        {
            Console.WriteLine($"Vidas restantes: {vidas}");
        }

        // Método Main para probar la clase
        public static void Main(string[] args)
        {
            // Crear primera instancia con 5 vidas
            Juego jugador1 = new Juego(5);
            jugador1.MuestraVidasRestantes(); // Debe mostrar 5

            // Restar una vida
            jugador1.vidas--;
            jugador1.MuestraVidasRestantes(); // Debe mostrar 4

            // Crear segunda instancia con 5 vidas
            Juego jugador2 = new Juego(5);
            jugador2.MuestraVidasRestantes(); // Debe mostrar 5

            // Volver a mostrar vidas del primer jugador
            jugador1.MuestraVidasRestantes(); // Debe mostrar 4

            // Esperar tecla para cerrar consola (opcional)
            Console.WriteLine("\nPresiona una tecla para salir...");
            
        }
    }
}

