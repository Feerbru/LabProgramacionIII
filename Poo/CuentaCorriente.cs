using System;
using static System.Console;

namespace Poo
{
    /*
     * una clase cuenta corriente
        se caracteriza por tener asociado un numero de cuenta y un saldo disponible.Además, se
        puede consultar el saldo disponible en cualquier momento, recibir depósitos y realizar
        extracciones y pagos.
     */
    class CuentaCorriente
    {
        public int nroCuenta { get; set; }
        public double saldo { get; set; }

        public CuentaCorriente()
        {
            this.nroCuenta = new Random().Next(1, int.MaxValue);
            this.saldo = 0;
        }

        public CuentaCorriente(double saldo)
        {
            this.nroCuenta = new Random().Next(1, int.MaxValue);
            this.saldo = saldo;
        }

        //metodo para consultar el saldo
        public void consultarSaldo()
        {
            WriteLine("Su saldo de su cuenta nro: "+ this.nroCuenta + " es: $" + this.saldo);
        }

        public void depositos(double saldo)
        {
            this.saldo += saldo;
        }

        public void extraer(double saldo)
        {
            this.saldo -= saldo;
        }

        public void transferencias(double saldo, CuentaCorriente cuenta)
        {
            this.saldo -= saldo;
            cuenta.saldo += saldo;
        }
    }
}
