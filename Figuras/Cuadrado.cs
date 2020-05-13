using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado(double la)
        {
            this.lado = la;
        }

        float Figura.Area()
        {
            return (float)Math.Pow(lado,2);
        }

    }
}
