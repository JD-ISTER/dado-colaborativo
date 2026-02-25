using System;

namespace JuegoDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== JUEGO DE DADOS ===");
            Console.WriteLine("Presiona ENTER para lanzar...");
            Console.ReadKey();

            Random rnd = new Random();
            int resultado = rnd.Next(1, 7);

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}