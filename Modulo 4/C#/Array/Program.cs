using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] losValores = new int[4]; //CREO EL VECTOR
            double[] Vnros;
            Vnros = new double[5];

            double total = 0;
            double prom = 0;
            losValores[0] = 1;
            losValores[1] = 2;
            losValores[2] = 3;
            losValores[3] = 4;
            

            //RECORRO EL VECTOR
            for(int i=0; i<losValores.Length; i++)
            {
                Console.WriteLine("Posicion ["+i+"]: "+losValores[i]);
            }
            //INGRESO DATOS AL VECTOR VIA ASIGNACION
            Vnros[0] = 10.5;
            Vnros[1] = 20.333;
            Vnros[2] = 30.999;
            Vnros[3] = 40.1;

            for (int j=0; j<Vnros.Length; j++)
            {
                Console.WriteLine("Posicion[" + j + "]: " + Vnros[j]);
                total += Vnros[j];
                prom = total / Vnros.Length;
            }
            Console.WriteLine("Total de la suma de todos los nros: " + total);
            Console.WriteLine("Promedio de todos los nros: " + prom);

            Console.ReadKey();

        }
    }
}
