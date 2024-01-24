using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cb = 0, cc=0;
            for (int i = 2; i <= 30; i += 2)
            {
                Console.WriteLine("{0}", i);
                if (i == 10)
                {
                    cb++;
                    Console.WriteLine("Salgo del ciclo usando un BREAK");
                    // break;
                    continue;
                }
            }
            Console.WriteLine("La cantidad de veces que aparece el 10 es: " + cb);
            Console.ReadKey();
        }
    }
}
