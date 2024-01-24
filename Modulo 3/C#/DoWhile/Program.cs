using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar != NRO, 
            -Calcular e informar suma, cant y prom
             */

            //Variables
            int nro, cant = 0, suma = 0;
            double prom = 0;

            do
            {
                Console.WriteLine("Ingrese un nro: ");
                nro = int.Parse(Console.ReadLine());
                if (nro != 0) {
                    suma += nro;
                    cant++;
                    prom = suma / cant;
                }

            } while (nro != 0); 

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Cantidad: " + cant);
            Console.WriteLine("Promedio: "+prom); 

            Console.ReadKey();
        }
    }
}
