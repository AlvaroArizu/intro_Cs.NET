using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Realizar un progrma que ingrese nros mientras sea distintos a 100
            -Se pide:
            1-Cantidad de +
            2- Cantidad de -
            3-Cntidad de 0
            4-Promedio de nros ingresados
            5-Porcentaje de nros +, -, y 0
             */

            //Variables
            int nros, cantPos = 0, cantNeg = 0, cantCeros = 0, cantReg=0;
            double promedio = 0, suma = 0, porcentajePos = 0, porcentajeNeg=0, porcentajeCeros=0;

            Console.WriteLine("Ingrese el nro: ");
            nros=int.Parse(Console.ReadLine());

            while (nros != 100)
            {
                cantReg++;
                if(nros == 0)
                {
                    cantCeros++;
                }
                else
                {
                    if (nros >0)
                    {
                        cantPos++;
                    }
                    else
                    {
                        cantNeg++;
                    }
                }
                suma += nros;
                promedio = suma / cantReg;
                porcentajePos = (cantPos * 100) / cantReg;
                porcentajeNeg = (cantNeg * 100) / cantReg;
                porcentajeCeros = (cantCeros * 100) / cantReg;

                Console.WriteLine("Ingrese el nro: ");
                nros = int.Parse(Console.ReadLine());
            }

            //Impresion de resultados 
            Console.WriteLine("_____RESULTADOS_____");
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Cantidad de registros: " + cantReg);
            Console.WriteLine("Cantidad de registros Positivos: " + cantPos);
            Console.WriteLine("Cantidad de registros Negativos: " + cantNeg);
            Console.WriteLine("Cantidad de registros de ceros: " + cantCeros);
            Console.WriteLine("Porcentaje Positivos: " + porcentajePos + "%");
            Console.WriteLine("Porcentaje Negativos: " + porcentajeNeg + "%");
            Console.WriteLine("Porcentaje De ceros: " + porcentajeCeros+ "%");

            Console.ReadKey();
        }
    }
}
