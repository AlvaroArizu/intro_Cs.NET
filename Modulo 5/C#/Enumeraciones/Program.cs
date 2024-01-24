using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    internal class Program
    {
        //Enumeracion 
        enum tipo_cuenta { CajaAhorro, CuentaCorriente, CuentaSueldo};
        enum moneda { Pesos=1, Dolares, Euros, Reales};
        static void Main(string[] args)
        {
            int nro = 0;

            //Variable del tipo cuenta
            tipo_cuenta cuenta;
            cuenta = tipo_cuenta.CuentaCorriente;

            //Pasamos de enumeracion a entero
            nro=(int)cuenta;

            Console.WriteLine($"La cuenta es una {cuenta} con valor {nro} ");

            //Variable del tipo moneda
            moneda moneda_cuenta = moneda.Pesos;

            Console.WriteLine($"La cuenta es una {cuenta} en {moneda_cuenta} con valor {nro}");

            Console.ReadKey();
        }
    }
}
