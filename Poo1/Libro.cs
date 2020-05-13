using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Poo1
{
    /*crear la clase Libro, cuyos
      atributos son el titulo, el autor, el número de paginas y la calicación que le damos entre 0 y 10.
      Crear los métodos típicos para poder modicar y obtener los atributos si tienen sentido.
    */

    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NroDePaginas { get; set; }

        private int calificacion;

        public int Calificacion
        {
            get { return calificacion; }
            set
            {
                if (value < 11)
                {
                    Calificacion = value;
                }
                else
                {
                    WriteLine("el nro tiene que estar dentro del rango 0 - 10.");
                    this.Calificacion = int.Parse(ReadLine());
                }
            }
        }


        public Libro(string titulo, string autor, int nroDePaginas, int calificacion)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.NroDePaginas = nroDePaginas;
            this.calificacion = calificacion;
        }
        public Libro() { }

        public override string ToString()
        {
            return "Titulo: " + Titulo + "\n" + "Autor: " + Autor + "\n"+ "Paginas: " + NroDePaginas + "\n";
        }
    }
}
