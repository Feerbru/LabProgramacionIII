using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Circulo : Figura
    {
        private double radio;

        public Circulo(double ra)
        {
            this.radio = ra;
        }

        float Figura.Area()
        {
            return (float)(Math.PI * Math.Pow(radio, 2));
        }
    }
}
