using System;

namespace JuegoDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== JUEGO DE DADOS ===");
            bool valido = false;

            while (!valido)
            {
                Console.WriteLine("Presiona ENTER para lanzar...");
                var tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.Enter)
                    valido = true;
                else
                    Console.WriteLine("Tecla inválida.");
            }

            Random rnd = new Random();
            int resultado = rnd.Next(1, 7);
            Console.WriteLine($"\nResultado: {resultado}");
        }
    }
}