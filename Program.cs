using KLQLator.Messages;
using KLQLator.Utils;
using System;

namespace KLQLator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Message messages = new();
            messages.Welcome();

            Orchestrator orchestrator = new();
            int operation; bool op;
            do
            {
                messages.Selector();

                op = int.TryParse(Console.ReadLine(), out operation);

                Console.WriteLine((op && operation != 0) ? orchestrator.ExecuteMathOperation((Operations)operation) : "");

            } while (operation != 0);

            messages.GoodBye();
        }
    }
}
