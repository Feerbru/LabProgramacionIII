using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Poo
{
    /*
     * Creara demás una clase Persona, que se caracteriza por un DNI y un array de cuentas
        bancarias. La Persona puede tener asociada hasta 3 cuentas bancarias, y debe tener un
        método que permite añadir cuentas (hasta 3 que es el máximo). También debe contener un
        método que devuelva si la persona es morosa, ej., si tienen alguna cuenta con saldo negativo.
     */
    class Persona
    {

        private int DNI;
        private CuentaCorriente[] cuentasBancarias = new CuentaCorriente[3];

        public Persona(int dni)
        {
            this.DNI = dni;
        }

        public int dni()
        {
            return this.DNI;
        }
        public Persona(int dni, CuentaCorriente cuenta)
        {
            this.DNI = dni;
            this.cuentasBancarias = añadirCuentas(cuenta);
        }

        public CuentaCorriente[] añadirCuentas(CuentaCorriente cuenta)
        {
            if (cuentasBancarias.Contains(null))
            {
                for (int i = 0; i < cuentasBancarias.Length; i++)
                {
                    if (cuentasBancarias[i] != null)
                    {
                        cuentasBancarias[i] = cuenta;
                    }
                }
            }
            else
            {
                WriteLine("No se puede agregar mas cuentas...");
            }
            
            return this.cuentasBancarias;
        }

        public bool esMorosa()
        {
            for (int i = 0; i < cuentasBancarias.Length; i++)
            {
                if (cuentasBancarias[i] != null)
                {
                    if (cuentasBancarias[i].saldo < 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
