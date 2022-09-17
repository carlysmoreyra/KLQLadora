using KLQLator.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLQLator.Messages
{
    class Message
    {
        private string name { get; set; }
        public void Welcome()
        {
            Console.WriteLine("Bienvenido a KLQLator!");

            Console.WriteLine("¿Cómo te llamas?");
            name = Console.ReadLine();
            while (name.Length == 0)
            {
                Console.WriteLine("¿Podrías indicarme tu nombre?");
                name = Console.ReadLine();
            }
            Console.WriteLine($"¡Gracias {name}! ¡Ahora pasemos a hacer algunas operaciones!");

        }

        public void Selector()
        {
            Console.WriteLine("¿Qué tipo de operación te gustaría realizar? Ingresa su número:");
            Console.WriteLine($"{(int)Operations.BasicMath}. Basics Math");
            Console.WriteLine($"{(int)Operations.ScientificMath}. Scientific Math");
            Console.WriteLine($"{(int)Operations.MatrixMath}. Matrix Math");
            Console.WriteLine($"{(int)Operations.Exit}. Salir");
        }

        public void GoodBye()
        {
            Console.WriteLine($"¡Hasta luego {name}! ¡Nos vemos la próxima vez!");
        }
    }
}
