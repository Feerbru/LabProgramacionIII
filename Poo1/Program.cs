using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Poo1
{
    /*
     *  Queremos mantener una colección de los libros que hemos ido leyendo, poniéndoles una
        calificación según nos haya gustado más o menos al leerlo. Para ello, crear la clase Libro, cuyos
        atributos son el titulo, el autor, el número de paginas y la calicación que le damos entre 0 y 10.
        Crear los métodos típicos para poder modicar y obtener los atributos si tienen sentido.
        Posteriormente, crear una clase ConjuntoLibros, que almacena un conjunto de libros (con un
        array de un tamaño fijo). Se pueden añadir libros que no existan (siempre que haya espacio),
        eliminar libros por título o autor, mostrar por pantalla los libros con la mayor y menor calicación
        dada y, por último, mostrar un contenido de todo el conjunto.
        Crear una clase PruebaLibros, que realice varias pruebas con las clases creadas. En concreto,
        pruebe a: crear dos libros, añadirlos al conjunto,
        eliminarlos por los dos criterios hasta que el conjunto esté vació, volver a añadir un libro y
        mostrar el contenido final.
     * */
    class Program
    {
        static void Main(string[] args)
        {

            ConjuntoLibros conjuntoLibros = new ConjuntoLibros(2);

            conjuntoLibros.Añadir("C#", "Matheu Ford", 56, 9);
            conjuntoLibros.Añadir("Css", "Marcos Palma", 156, 1);

            conjuntoLibros.Mostrar();

            conjuntoLibros.Eliminar();
            conjuntoLibros.Eliminar();

            conjuntoLibros = new ConjuntoLibros(1);
            conjuntoLibros.Añadir("Code","Saint Freud",44,6);

            conjuntoLibros.Mostrar();
            ReadKey();
        }

    }
}