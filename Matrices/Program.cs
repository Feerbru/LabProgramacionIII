using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Matrices
{/*
     * Alumno: Fernando Matias Bruzzo - TUP 2020
     * 
     * Se solicita que desarrolle una aplicación en C# que utilizando un menú permita a un usuario realizar
       diferentes operaciones de matrices.
       1. Carga de dos matriz en forma manual
       2. Carga de una matriz en forma automática con números aleatorios.
       3. Matriz transpuesta
       4. Traza de una matriz
       5. Determinar si una matriz es del tipo identidad
       6. Matriz diagonal
       7. Multiplicación escalar
       8. Suma de dos matrices
       9. Resta de matrices
       10. Determinar la igualdad de dos matrices
     * */

    class Program
    {
        static int[,] tab = new int[2, 2];
        static int[,] tab1 = new int[2, 2];
        static int[,] aux = new int[2, 2];

        static void Main(string[] args)
        {
            Menu();
        }

        //funtion Menu
        static void Menu()
        {
            int opcion;
            string seguir = "si";

            do
            {
                WriteLine("OPERACIONES DE MATRICES: \n" +
                          "\t1. Carga de dos matriz en forma manual \n" +
                          "\t2. Carga de una matriz en forma automática con números aleatorios. \n" +
                          "\t3. Matriz transpuesta \n" +
                          "\t4. Traza de una matriz \n" +
                          "\t5. Determinar si una matriz es del tipo identidad \n" +
                          "\t6. Matriz diagonal \n" +
                          "\t7. Multiplicación escalar \n" +
                          "\t8. Suma de dos matrices \n" +
                          "\t9. Resta de matrices \n" +
                          "\t10.Determinar la igualdad de dos matrices\n" +
                          "Ingrese la opcion que desea realizar:");

                opcion = int.Parse(ReadLine());

                if (opcion > 0 && opcion < 11) //comprueba que este en el rango establecido
                {
                    Clear(); //Limpiar pantalla
                    opciones(opcion);
                }
                else
                {
                    Clear();
                    WriteLine("Error! no comprende al rango establecido.\n" +
                              "Por Favor!!! Vuelva a intentar...\n");
                    Menu();
                }

                WriteLine("\nDesea Realizar otra operacion: \n" + "" +
                            "si\n" +
                            "no");
                seguir = ReadLine();

                Clear(); //Limpiar Pantalla

            } while (seguir != "no");

            ReadKey();
        }
        //Opciones del Menu
        static void opciones(int opc)
        {
            //int[,] tab = new int[2, 2];
            //int[,] tab1 = new int[2, 2];
            int nro;
            string cont;

            switch (opc)
            {
                case 1:
                    //Mostrar(CargaManual(tab));
                    tab = CargaManual();
                    Clear();
                    WriteLine("Matriz A");
                    Mostrar(tab);

                    WriteLine("Desea Cargar otra matriz: ");
                    cont = ReadLine();

                    if (cont == "si")
                    {
                        tab1 = CargaManual();
                        Clear();
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                    }
                    break;
                case 2:
                    tab = Cargar();
                    Clear();
                    WriteLine("Matriz A");
                    Mostrar(Cargar());

                    WriteLine("Desea Cargar otra matriz: ");
                    cont = ReadLine();

                    if (cont == "si")
                    {
                        tab1 = Cargar();
                        Clear();
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                    }
                    break;
                case 3:
                    if (estaVacia(tab))
                    {
                        tab = CargarManOAut();
                        Clear();
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    else
                    {
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    MatrizTranspuesta(tab);
                    WriteLine("Desea Cargar otra matriz: ");
                    cont = ReadLine();

                    if (cont == "si")
                    {
                        tab1 = CargarManOAut();
                        Clear();
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                        WriteLine("\nMatriz Transpuesta de B");
                        MatrizTranspuesta(tab1);
                    }
                    break;
                case 4:
                    if (estaVacia(tab))
                    {
                        tab = CargarManOAut();
                        Clear();
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    else
                    {
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    WriteLine("La traza de la matriz A es:");
                    TrazaDeMatriz(tab);
                    break;
                case 5:
                    if (estaVacia(tab))
                    {
                        tab = CargarManOAut();
                        Clear();
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    else
                    {
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    if (MatrizDeIdentidad(tab))
                    {
                        WriteLine("Si es matriz de identidad");
                    }
                    else
                    {
                        WriteLine("No es matriz de identidad");
                    }
                    break;
                case 6:
                    if (estaVacia(tab))
                    {
                        tab = CargarManOAut();
                        Clear();
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    else
                    {
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    if (MatrizDiagonal(tab))
                    {
                        WriteLine("Si es matriz diagonal");
                    }
                    else
                    {
                        WriteLine("No es matriz diagonal");
                    }
                    break;
                case 7:
                    if (estaVacia(tab))
                    {
                        tab = CargarManOAut();
                        Clear();
                        WriteLine("Matriz A");
                        Mostrar(tab);
                    }
                    WriteLine("Por que nro desea multiplicar la matriz:");
                    nro = int.Parse(ReadLine());
                    aux = multiplicacionEscalar(tab, nro);
                    Clear();
                    WriteLine("El resultado de la multiplicacion de las matriz es:\n");
                    Mostrar(aux);
                    break;
                case 8:
                    if (estaVacia(tab) || (estaVacia(tab) && estaVacia(tab1)))
                    {
                        tab = CargarManOAut();
                        tab1 = CargarManOAut();
                        Clear();
                        WriteLine("Matriz A");
                        Mostrar(tab);
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                    }
                    else
                    {
                        WriteLine("Matriz A");
                        Mostrar(tab);
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                    }
                    aux = sumaDeDosMatrices(tab, tab1);
                    WriteLine("La suma de las matrices es: ");
                    Mostrar(aux);

                    break;
                case 9:
                    if (estaVacia(tab) || (estaVacia(tab) && estaVacia(tab1)))
                    {
                        tab = CargarManOAut();
                        tab1 = CargarManOAut();
                        Clear();
                        WriteLine("Matriz A");
                        Mostrar(tab);
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                    }
                    else
                    {
                        WriteLine("Matriz A");
                        Mostrar(tab);
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                    }
                    aux = restaMatrices(tab, tab1);
                    WriteLine("La resta de las matrices es: ");
                    Mostrar(aux);
                    break;
                case 10:
                    if (estaVacia(tab) || (estaVacia(tab) && estaVacia(tab1)))
                    {
                        tab = CargarManOAut();
                        tab1 = CargarManOAut();
                        Clear();
                        WriteLine("Matriz A");
                        Mostrar(tab);
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                    }
                    else
                    {
                        WriteLine("Matriz A");
                        Mostrar(tab);
                        WriteLine("Matriz B");
                        Mostrar(tab1);
                    }
                    if (igualdadMatrices(tab, tab1) == true)
                    {
                        WriteLine("Las matrices si son iguales");
                    }
                    else
                    {
                        WriteLine("Las matrices no son iguales");
                    }
                    break;
                default:
                    WriteLine("Error! no comprende al rango establecido.\n" +
                              "Por Favor!!! Vuelva a intentar...\n");
                    break;
            }
        }

        static int[,] CargarManOAut()
        {
            int nro;
            WriteLine("Desea Cargar la matriz en forma: \n" +
                        " 1. Manual\n" +
                        " 2. Automatico");
            nro = int.Parse(ReadLine());
            if (nro == 1)
                return CargaManual();
            else
                return Cargar();

        }
        /*static void VolverMenu()
        {
            string conti;
            WriteLine("Desea realizar otra Operacion:\n"+
                        "si\n"+
                        "no");
            conti = ReadLine();
            if(conti == "si")
            {
                Clear();
                Menu();
            }
        }*/



        //funtion de CargaManual
        /*static int [,] CargaManual(int [,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Write("ingrese la posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    tab[i,j] = int.Parse(ReadLine());
                }
            }
            return tab;
        }*/

        static int[,] CargaManual()
        {
            int[,] matrizA = new int[2, 2];
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Write("ingrese la posicion [" + (i + 1) + "," + (j + 1) + "]: ");
                    matrizA[i, j] = int.Parse(ReadLine());
                }
            }
            WriteLine();
            return matrizA;
        }

        //funtion Cargar
        static int[,] Cargar()
        {
            Random r = new Random();
            int[,] matrizA = new int[2, 2];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = r.Next(1, 9);
                }
            }
            WriteLine();
            return matrizA;
        }
        //funtion Mostrar
        static void Mostrar(int[,] matrizA)
        {
            //WriteLine("<<<<<<<<<<<Matriz>>>>>>>>>>");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Write("{0} ", matrizA[i, j]);
                }
                WriteLine();
            }
            WriteLine();
        }
        //funtion Mayor
        static int Mayor(int[,] tab)
        {
            int length = 2, aux = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (aux < tab[i, j])
                    {
                        aux = tab[i, j];
                    }
                }
            }
            return aux;
        }

        //funtion de Matriz Transpuesta
        static int[,] MatrizTranspuesta(int[,] matrizA)
        {
            //WriteLine("<<<<<<<<<Matriz Transpuesta>>>>>>>>>");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Write("{0} ", matrizA[j, i]);
                }
                WriteLine();
            }
            WriteLine();
            return matrizA;
        }

        //Funcion Traza de Matriz
        static void TrazaDeMatriz(int[,] matrizA)
        {
            int traza = 0;

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        traza += matrizA[i, j];
                    }
                }
            }
            Clear();
            WriteLine("La traza de la matriz es: " + traza);
        }

        //funcion Matriz de identidad
        static bool MatrizDeIdentidad(int[,] matrizA)
        {

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (matrizA[i, j] == 1)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (matrizA[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //funtion de matriz Diagonal
        static bool MatrizDiagonal(int[,] matrizA)
        {
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (matrizA[i, j] != 0)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (matrizA[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //funtion para comprobar si esta vacia la matriz
        static bool estaVacia(int[,] matrizA)
        {
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (matrizA[i, j] == 0)
                    {
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //Funtion scalar multiplication
        static int[,] multiplicacionEscalar(int[,] matrizA, int num)
        {
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    aux[i, j] = num * matrizA[i, j];
                }
            }
            return aux;
        }

        // Funtion Suma de dos matrices
        static int[,] sumaDeDosMatrices(int[,] matrizA, int[,] matrizB)
        {
            if (matrizA.GetLength(0) == matrizB.GetLength(1) && matrizA.GetLength(1) == matrizB.GetLength(1))
            {
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        aux[i, j] = tab[i, j] + tab1[i, j];
                    }
                }
            }
            else
            {
                WriteLine("Las matrices deben ser iguales para sumarse");
                return null;
            }
            return aux;
        }

        //Resta de matrices
        static int[,] restaMatrices(int[,] matrizA, int[,] matrizB)
        {
            if (matrizA.GetLength(0) == matrizB.GetLength(1) && matrizA.GetLength(1) == matrizB.GetLength(1))
            {
                for (int i = 0; i < matrizA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizA.GetLength(1); j++)
                    {
                        aux[i, j] = matrizA[i, j] - matrizB[i, j];
                    }
                }
            }
            else
            {
                WriteLine("Las matrices deben ser iguales para restarse");
                return null;
            }
            return aux;
        }

        //Determinar la igualdad de dos matrices
        static bool igualdadMatrices(int[,] matrizA, int[,] matrizB)
        {
            if (matrizA.GetLength(0) == matrizB.GetLength(0) && matrizA.GetLength(1) == matrizB.GetLength(1))
            {
                for (int i = 0; i < matrizA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizA.GetLength(1); j++)
                    {
                        if (matrizA[i, j] != matrizB[i, j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
