using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(10)); // Radio=10
            figuras.Add(new Cuadrado(10)); // Lado=10
            figuras.Add(new Triangulo(10, 5)); // Base=10, Altura = 5;

            foreach(Figura f in figuras)
                WriteLine("Área: " + f.Area());

            ReadKey();
        }
    }
}
