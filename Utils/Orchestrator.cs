using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLQLator.Utils
{
    class Orchestrator
    {
        public string ExecuteMathOperation(Operations operation)
        {
            string result = "";
            switch (operation)
            {
                case Operations.BasicMath:
                    {
                        //TODO: Llamar y ejecutar a la clase BasicMath
                        result = "Esta función todavía no se encuentra implementada."; 
                        break;
                    }
                case Operations.MatrixMath:
                    {
                        //TODO: Llamar y ejecutar a la clase MatrixMath
                        result = "Esta función todavía no se encuentra implementada."; 
                        break;
                    }
                case Operations.ScientificMath:
                    {
                        //TODO: Llamar y ejecutar a la clase ScientificMath
                        result = "Esta función todavía no se encuentra implementada."; 
                        break;
                    }
                default:
                    {
                        result = "Esta función todavía no se encuentra implementada.";
                        break;
                    }
            }
            return result;
        }
    }
}
