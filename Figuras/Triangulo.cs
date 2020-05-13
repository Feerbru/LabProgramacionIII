using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Triangulo : Figura
    {
        private double baase;

        private double altura;

        public Triangulo(float bas, float alt)
        {
            this.baase = bas;
            this.altura = alt;
        }


        float Figura.Area()
        {
            return (float)(Math.Pow((baase * altura), 2)) ;
        }
    }
}
