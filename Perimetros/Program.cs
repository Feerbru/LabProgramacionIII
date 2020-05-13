using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Perimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            //Polimorfismo
            WriteLine("<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>");
            t.PerCuadradoP();
            WriteLine("<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>");
            t.PerRectanguloP();

            WriteLine("<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>");

            //Inyeccion
            Cuadrado p = new Cuadrado(23);
            t.PerCuadradoI(p);

            WriteLine("<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>");
            t.PerTrianguloI(new Triangulo(23,45));


            Console.Read();
        }
    }

    class Test
    {
        IPerimetro per;

        //probamos Polimorfismo

        public void PerRectanguloP()
        {
            this.per = new Rectangulo(10, 5);
            this.per.Area();
        }
        public void PerCuadradoP()
        {
            this.per = new Cuadrado(6);
            this.per.Area();
        }
        public void PerParalelogramoP()
        {
            this.per = new Paralelogramo(5,8);
            this.per.Area();
        }
        public void PerRomboP()
        {
            this.per = new Rombo(11,25);
            this.per.Area();
        }
        public void PerTrianguloP()
        {
            this.per = new Triangulo(3, 9);
            this.per.Area();
        }


        //probamos inyeccion de dependencias

        public void PerRectanguloI(IPerimetro p)
        {
            this.per = p;
            this.per.Area();
        }
        public void PerRomboI(IPerimetro p)
        {
            this.per = p;
            this.per.Area();
        }
        public void PerTrianguloI(IPerimetro p)
        {
            this.per = p;
            this.per.Area();
        }
        public void PerCuadradoI(IPerimetro p)
        {
            this.per = p;
            this.per.Area();
        }
        public void PerParalelogramoI(IPerimetro p)
        {
            this.per = p;
            this.per.Area();
        }

    }

    interface IPerimetro
    {
        void Area();
    }
    class Rectangulo : IPerimetro
    {
        private double bas;
        private double altura;

        public Rectangulo(double bas, double altura)
        {
            this.bas = bas;
            this.altura = altura;
        }

        void IPerimetro.Area()
        {
             WriteLine("El perimetro del Rectangulo es: " + (altura * bas));
        }

    }

    class Cuadrado : IPerimetro
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        void IPerimetro.Area()
        {
            WriteLine("El perimetro del Cuadrado es: " + (Math.Pow(lado,2)));
        }

    }

    class Paralelogramo : IPerimetro
    {
        private double altura;
        private double bas;

        public Paralelogramo(double altura, double bas)
        {
            this.altura = altura;
            this.bas = bas;
        }

        void IPerimetro.Area()
        {
            WriteLine("El perimetro del Paralelogramo es: " + (altura * bas));
        }
    }

    class Rombo : IPerimetro
    {
        private double diametro1;
        private double diametro2;

        public Rombo(double diametro1, double diametro2)
        {
            this.diametro1 = diametro1;
            this.diametro2 = diametro2;
        }

        void IPerimetro.Area()
        {
            WriteLine("El perimetro del Rombo es: " + ((diametro1 / diametro2) / 2));
        }
    }

    class Triangulo :IPerimetro
    {
        private double altura;
        private double bas;

        public Triangulo(double altura, double bas)
        {
            this.altura = altura;
            this.bas = bas;
        }

        void IPerimetro.Area()
        {
            WriteLine("El perimetro del Triangulo es: " + ((altura * bas) / 2));
        }
    }
}
