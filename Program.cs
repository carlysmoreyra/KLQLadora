using KLQLator.Utils;
using System;

namespace KLQLator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Bienvenido a KLQLator!");
            Console.WriteLine("¿Cómo te llamas?");
            name = Console.ReadLine();
            while(name.Length == 0)
            {
                Console.WriteLine("¿Podrías indicarme tu nombre?");
                name = Console.ReadLine();
            }
            Console.WriteLine($"¡Gracias {name}! ¡Ahora pasemos a hacer algunas operaciones!");

            Orchestrator orchestrator = new();
            int operation; bool op;
            do
            {
                Console.WriteLine("¿Qué tipo de operación te gustaría realizar? Ingresa su número:");
                Console.WriteLine($"{(int)Operations.BasicMath}. Basics Math");
                Console.WriteLine($"{(int)Operations.ScientificMath}. Scientific Math");
                Console.WriteLine($"{(int)Operations.MatrixMath}. Matrix Math");
                Console.WriteLine($"{(int)Operations.Exit}. Salir");
                op = int.TryParse(Console.ReadLine(), out operation);

                Console.WriteLine((op && operation != 0) ? orchestrator.ExecuteMathOperation((Operations)operation) : "");

            } while (operation != 0);

            Console.WriteLine($"¡Hasta luego {name}! ¡Nos vemos la próxima vez!");
        }
    }
}
