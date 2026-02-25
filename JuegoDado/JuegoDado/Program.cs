using System;
using System.Collections.Generic;

namespace JuegoDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== JUEGO DE DADOS ===");
            List<int> historial = new List<int>();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Enter para lanzar, 'S' para salir:");
                var input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.S) { salir = true; continue; }
                if (input.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("\nTecla inválida.");
                    continue;
                }

                Random rnd = new Random();
                int res = rnd.Next(1, 7);
                historial.Add(res);

                Console.WriteLine($"\nResultado: {res}");
                // Historial últimos 5
                var ultimos = historial.Count > 5 ? historial.GetRange(historial.Count - 5, 5) : historial;
                Console.WriteLine($"Historial: {string.Join(", ", ultimos)}");
            }
        }
    }
}