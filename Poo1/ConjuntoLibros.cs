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
    class ConjuntoLibros : Libro
    {
        Libro[] conjuntoDeLibros;
        int cantLibros;

        public ConjuntoLibros(int cantLibros, string titulo, string autor, int nroDePaginas, int calificacion) : base(titulo,autor,nroDePaginas,calificacion)
        {
            conjuntoDeLibros = new Libro[cantLibros];
        }

        public ConjuntoLibros(int cantLibros)
        {
            this.cantLibros = cantLibros;
            conjuntoDeLibros = new Libro[cantLibros];
        }

        public void Añadir(string titulo, string autor, int nroDePaginas, int calificacion)
        {
            Libro libro = new Libro(titulo, autor, nroDePaginas, calificacion);

            for (int i = 0; i < cantLibros; i++)
            {
                if (conjuntoDeLibros[i] == null)
                {
                    conjuntoDeLibros[i] = libro;
                    break;
                }
            }
                
        }

        public void Mostrar()
        {
            for (int i = 0; i < cantLibros; i++)
            {
                WriteLine(conjuntoDeLibros[i].ToString());
            }
        }

        //metodo Eliminar
        public Libro[] Eliminar()
        {
            int nro;
            string nombre;
            WriteLine("Desea eliminar un libro por: \n"+
                      "1- Titulo. \n"+
                      "2- Autor.");
            nro = int.Parse(ReadLine());
            switch (nro)
            {
                case 1:
                    WriteLine("Ingrese el titulo a eliminar: ");
                    nombre = ReadLine();
                    for (int i = 0; i < cantLibros; i++)
                    {
                        if (conjuntoDeLibros[i].Titulo.Equals(nombre))
                        {
                            conjuntoDeLibros[i] = null;
                            cantLibros --;
                            conjuntoDeLibros[i] = conjuntoDeLibros[cantLibros];
                            return conjuntoDeLibros;
                        }
                    }
                    break;

                case 2:
                    WriteLine("Ingrese el Autor a eliminar: ");
                    nombre = ReadLine();
                    for (int i = 0; i < cantLibros; i++)
                    {
                        if (conjuntoDeLibros[i].Autor.Equals(nombre))
                        {
                            conjuntoDeLibros[i] = null;
                            cantLibros--;
                            conjuntoDeLibros[i] = conjuntoDeLibros[cantLibros];
                            return conjuntoDeLibros;
                        }
                    }
                    break;
                default:
                    WriteLine("Opcion erronea!!!");
                    break;
            }
            return conjuntoDeLibros;
        }

        public void MayorYMenor()
        {
            int auxMayor = 0;
            int auxMenor = 0;
            int posM = 0;
            int posMn = 0;

            for (int i = 0; i < cantLibros; i++)
            {

                if (conjuntoDeLibros[i].Calificacion > auxMayor)
                {
                    auxMayor = conjuntoDeLibros[i].Calificacion;
                    posM = i;
                }
                else
                {
                    auxMenor = conjuntoDeLibros[i].Calificacion;
                }
            }

            for (int i = 0; i < cantLibros; i++)
            {
                if (conjuntoDeLibros[i].Calificacion < auxMenor)
                {
                    auxMenor = conjuntoDeLibros[i].Calificacion;
                    posM = i;
                }
            }

            WriteLine("El Libro que tiene mayor calificacion es: " + conjuntoDeLibros[posM] + "fue calificado con: " + auxMayor);
            WriteLine("El Libro que tiene menor calificacion es: " + conjuntoDeLibros[posMn] + "fue calificado con: " + auxMenor);
        }

        public void comprobar()
        {
            if (Vacio())
            {
                WriteLine("esta vacio");
            }
            else
            {
                WriteLine("esta lleno");
            }
        }

        //Comprueba si la biblioteca esta vacia
        private bool Vacio()
        {

            for (int i = 0; i < cantLibros; i++)
            {
                if (conjuntoDeLibros[i] == null)
                {
                    
                    return true;
                }

            }
            return false;
        }
        
    }

}
