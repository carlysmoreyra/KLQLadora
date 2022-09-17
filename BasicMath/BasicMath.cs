using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLQLator.BasicMath
{
    class BasicMath
    {

        public int Suma(int[] sumatoria)
        {
            int suma = 0;
            foreach (int s in sumatoria)
            {
                suma += s;
            }
            return suma;
        }

        public int Producto(int[] productoria)
        {
            int producto = 1;
            foreach (int p in productoria)
            {
                producto *= p;
            }
            return producto;
        }

        public int Resta(int[] restando)
        {
            int resto = restando[0];
            for(int i = 1; i < restando.Length; i++)
            {
                resto -= restando[i];
            }
            return resto;
        }

        public int Division(int[] divisores)
        {
            int div = divisores[0];
            for (int i = 1; i < divisores.Length; i++)
            {
                div /= divisores[i];
            }
            return div;
        }
    }
}
