using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo1
{
    /*crear la clase Libro, cuyos
      atributos son el titulo, el autor, el número de paginas y la calicación que le damos entre 0 y 10.
      Crear los métodos típicos para poder modicar y obtener los atributos si tienen sentido.
    */

    class Libro
    {
        private string titulo { get; set; }
        private string autor { get; set; }
        private int nroDePaginas { get; set; }
        private int calificacion { get; set; }

        public Libro(string titulo, string autor, int nroDePaginas, int calificacion)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.nroDePaginas = nroDePaginas;
            this.calificacion = calificacion;
        }
    }
}
