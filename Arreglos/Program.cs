using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arreglos
{
    class Program
    /*
     *  En la siguiente entrega les paso el código de la función main para que puedan transformarla para
        realizar el siguiente practico. Solicitaran al usuario que ingrese cinco númeross por teclado y los
        guardaran en un arreglo estático que recorrerán para realizar las siguientes operaciones.
        1: sumar los números de la colección
        2: restar los números de la colección;
        3: sumar los números en posiciones pares de la colección;
        4: sumar los números de las pociones pares y restar los números de posiciones impares de la colección;
        5: hallar el máximo de la colección
        6: sacar el promedio de la colección
        El programa realizara las siguientes operaciones tantas veces como el usuario desee, usar
        como condiciónn de salida de la aplicaciónn que el usuario ingrese "no" por teclado.
     */
    {
        static void Main(string[] args)
        {
            int[] tab = new int[5];
            int seguir;

            do
            {
                WriteLine("Cargamos la coleccion: ");
                //Solicitamos que el usuario cargue el arreglo
                for (int i = 0; i < tab.Length; i++)
                {
                    WriteLine("Ingrese un numero:");
                    tab[i] = int.Parse(ReadLine());
                }

                int op = 0;
                WriteLine("Lo suma o lo resta");
                WriteLine("1: suma los numeros del arreglo");
                WriteLine("2: resta los numeros del arreglo");
                WriteLine("3: sumar los números en posiciones pares del arreglo");
                WriteLine("4: sumar los números de las pociones pares y restar los números de posiciones impares del arreglo");
                WriteLine("5: hallar el máximo del arreglo");
                WriteLine("6: sacar el promedio del arreglo");
                op = int.Parse(ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            suma(tab);
                        }
                        break;
                    case 2:
                        {
                            resta(tab);
                        }
                        break;
                    case 3:
                        {
                            sumarPosPares(tab);
                        }
                        break;
                    case 4:
                        {
                            sumPosParesYRestaPosImp(tab);
                        }
                        break;
                    case 5:
                        {
                            maxArr(tab);
                        }
                        break;
                    case 6:
                        {
                            promedio(tab);
                        }
                        break;
                    default:
                        WriteLine("La opcion seleccionada no es valida.");
                        break;
                }

                WriteLine("Desea continuar:");
                WriteLine("1- Si.");
                WriteLine("2- No.");
                seguir = int.Parse(ReadLine());

            } while (seguir != 2);

        }
        //sumar los números de la colección
        public static void suma(int[] arr)
        {
            int total = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            WriteLine("La suma de los numeros de la coleccion es: " + total);
        }

        //restar los números de la colección
        public static void resta(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total -= arr[i];
            }
            WriteLine("La resta de los numeros de la coleccion es: " + total);
        }
        //sumar las posiciones pares de la coleccion
        public static void sumarPosPares(int[] arr)
        {
            int totalPares = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    totalPares += arr[i];
                }
            }
            WriteLine("La suma de las posiciones pares de la coleccion es: " + totalPares);
        }

        //sumar los números de las pociones pares y restar los números de posiciones impares del arreglo
        public static void sumPosParesYRestaPosImp(int[] arr)
        {
            int total = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    total += arr[i];
                }
                else
                {
                    total -= arr[i];
                }
            }
            WriteLine("La suma de las posiciones pares y resta las posiciones impares de la coleccion da un total de: " + total);
        }

        //hallar el máximo del arreglo
        public static void maxArr(int[] arr)
        {
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            WriteLine("El numero maximo de la coleccion es: " + max);
        }

        //sacar el promedio del arreglo
        public static void promedio(int[] arr)
        {
            int suma = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
            }

            WriteLine("El promedio de la coleccion es: " + (suma / arr.Length) + "%");
        }
    }
}
