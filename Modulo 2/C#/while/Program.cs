using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ingresar distintos numeros que sean distintos de 0

            Se pide:
            1-Cantidad de nro ingresasdos
            2-Suma
            3-Promedio
            */

            //Variables
            int nros, cantReg = 0;
            double suma = 0, promedio = 0;

            Console.Write("Ingrese nro: ");
            nros = int.Parse(Console.ReadLine());
            while (nros != 0)
            {
                cantReg++;
                suma += nros;
                promedio = suma / cantReg;

                Console.Write("Ingrese nro: ");
                nros = int.Parse(Console.ReadLine());
            }

            //Impresion de resultados 
            Console.WriteLine("_____RESULTADOS_____");
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Cantidad de registros: " + cantReg);

            Console.ReadKey();
        }
    }
}
