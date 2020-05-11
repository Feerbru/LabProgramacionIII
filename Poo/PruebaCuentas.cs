using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Poo
{
    /*
     * Practico1:
        Desarrolle una programa orientado a objetos en C#, para gestionar una clase cuenta corriente
        se caracteriza por tener asociado un numero de cuenta y un saldo disponible.Además, se
        puede consultar el saldo disponible en cualquier momento, recibir depósitos y realizar
        extracciones y pagos.
        Creara demás una clase Persona, que se caracteriza por un DNI y un array de cuentas
        bancarias. La Persona puede tener asociada hasta 3 cuentas bancarias, y debe tener un
        método que permite añadir cuentas (hasta 3 que es el máximo). También debe contener un
        método que devuelva si la persona es morosa, ej., si tienen alguna cuenta con saldo negativo.

        Crear una clase Prueba Cuentas que instancie un objeto Persona con un dni cualquiera, así
        como dos objetos cuenta, una sin saldo inicial y otra con 700 euros. La persona recibe la
        nomina mensual, por lo que ingresa 1100 euros en la primera cuenta, pero tiene que pagar el
        alquiler de 750 euros con la segunda. Imprimir por pantalla el si la persona es morosa.
        Posteriormente hacer una transferencia de una cuenta a otra y comprobar mostrándolo por
        pantalla que cambia el estado de la persona.
     * */
    class PruebaCuentas
    {
        static void Main(string[] args)
        {
            CuentaCorriente c1 = new CuentaCorriente(0);
            CuentaCorriente c2 = new CuentaCorriente(700);
            CuentaCorriente c3 = new CuentaCorriente(0);

            Persona per1 = new Persona(34413813);

            per1.añadirCuentas(c1);
            per1.añadirCuentas(c2);
            per1.añadirCuentas(c3);


            c1.depositos(1100);
            c2.extraer(750);

            if (per1.esMorosa())
            {
                WriteLine("Si es morosa");
            }
            else
            {
                WriteLine("No es morosa");
            }

            c1.transferencias(200, c2);

            if (per1.esMorosa())
            {
                WriteLine("Si es morosa");
            }
            else
            {
                WriteLine("No es morosa");
            }


            WriteLine();
            ReadKey();

        }
    }
}
