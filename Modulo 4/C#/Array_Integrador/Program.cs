using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Integrador
{
    internal class Program
    {
        //---------FUNCIONES----------//
        static double CalcularPorcentaje(int cant, int total)
        {
            return (cant *100)/ total;
        }
        static void Main(string[] args)
        {
            /*
             Generar un vec llamado vecNroa que pida 10 nros.
            1-Informar cant de nros par e impar
            2-Suma y Prom
            3-Max valor y posicion
            4-Min valor y posicion
            5-Veces que aparece un determinado nro
            6-Informar porcentajes de nros par e impares, usando un FX llamada: CalcularPorcentaje
             
             */

            //DECLARACION DE VARIABLES
            int cpares=0, cimpares=0, total=0, maxPos=0, minPos=0;
            double prom = 0;

            // Inicializa max con el valor mínimo posible
            int max = int.MinValue;
            // Inicializa min con el valor máximo posible
            int min = int.MaxValue;

            int[] vecNros = new int[10];

            for(int i = 1; i < vecNros.Length; i++)
            {
                Console.WriteLine("INGRESE NROS: ");
                vecNros[i]=int.Parse(Console.ReadLine());

                //Nros pares e impares
                if (vecNros[i]%2 == 0)
                {
                    cpares++;
                    
                }
                else
                {
                    cimpares++;
                    
                }

                //Max y min 
                if (vecNros[i] > max)
                {
                    max = vecNros[i];
                    maxPos = i;
                }
                
                if (vecNros[i] < min)
                {
                    min = vecNros[i];
                    minPos = i;
                }

                //Suma y pro
                total += vecNros[i];
                prom= total / vecNros.Length;

                //Veces que aparece un determinado nro
                if (vecNros[i] == 10)
                {
                    Console.WriteLine("El nro buscado, se encuentra en la posicion: " + i);
                }
                else
                {
                    Console.WriteLine("El nro buscado, NO se encuentra en la posicion: " + i);
                }

            }
            Console.WriteLine("____RESULTADOS____");
            Console.WriteLine("Cantidad de nros pares: "+cpares);
            Console.WriteLine("Cantidad de nros impares: "+cimpares);
            Console.WriteLine("Suma de todos los nros: "+total);
            Console.WriteLine("Promedio de todos los nros: "+prom);
            Console.WriteLine("Max: "+ max+" en la posicion ["+maxPos+"]");
            Console.WriteLine("Min: " + min + " en la posicion [" + minPos + "]");

            //________________________________FUNCIONES_________________________________//
            //Porcentajes de nros par e impares, usando un FX llamada: CalcularPorcentaje
            Console.WriteLine("El porcentaje de nros pares es: "+ CalcularPorcentaje(cpares, vecNros.Length)+"%");
            Console.WriteLine("El porcentaje de nros impares es: " + CalcularPorcentaje(cimpares, vecNros.Length) + "%");


            Console.ReadKey();
        }
    }
}
