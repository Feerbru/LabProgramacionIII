using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Poo1
{
    /*  Posteriormente, crear una clase ConjuntoLibros, que almacena un conjunto de libros (con un
        array de un tamaño fijo). Se pueden añadir libros que no existan (siempre que haya espacio),
        eliminar libros por título o autor, mostrar por pantalla los libros con la mayor y menor calicación
        dada y, por último, mostrar un contenido de todo el conjunto.
    */
    class ConjuntoLibros
    {
        Libro[] conjuntoDeLibros = new Libro[5];

        public ConjuntoLibros(Libro[] conjuntoDeLibros)
        {
            this.conjuntoDeLibros = conjuntoDeLibros;
        }






        //Agregar libros
        public Libro[] agregar(Libro libro)
        {
            if (Vacio())
            {
                for (int i = 0; i < conjuntoDeLibros.Length; i++)
                {
                    if (conjuntoDeLibros[i] == null)
                    {
                        conjuntoDeLibros[i] = libro;
                    }
                }
            }
            else
            {
                WriteLine("Esta llena la biblioteca de libros!");
            }

            return conjuntoDeLibros;
        }

        //Eliminar libros por autor


        //Comprueba si la biblioteca esta vacia
        private bool Vacio()
        {

            for (int i = 0; i < conjuntoDeLibros.Length; i++)
            {
                if (conjuntoDeLibros[i] == null)
                {
                    WriteLine("Le quedan " + (conjuntoDeLibros.Length - i) + " lugares");
                    return true;
                }

            }
            return false;
        }
        
    }

}
