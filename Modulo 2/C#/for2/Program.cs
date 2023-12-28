using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir los numeros del 2 al 30 con un incremento del del 2

            for(int i=2; i <= 30; i += 2)
            {
                Console.WriteLine("{0}", i);
            }

            Console.ReadKey();
        }
    }
}
