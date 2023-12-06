using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico2_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generar un programa que ingrese 2 numeros, informar si son =, > o <
            double nro1, nro2;
            Console.WriteLine("Ingrese el 1er nro: ");
            nro1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do nro: ");
            nro2 = double.Parse(Console.ReadLine());
             
            if(nro1 > nro2)
            {
                Console.WriteLine("{0} es mayor a {1}", nro1, nro2);
            }
            else
            {
                if(nro1 < nro2)
                {
                    Console.WriteLine("{0} es menor a {1}", nro1, nro2);
                }else
                {
                    Console.WriteLine("{0} es igual a {1}", nro1, nro2);
                }
            }
            Console.ReadKey();
        }
    }
}
