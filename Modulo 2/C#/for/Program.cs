using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo for
            Console.WriteLine("Ciclo [FOR] INCREMENTAR");
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Valores: "+ i);
            }

            Console.WriteLine("\nCiclo [FOR] DECREMENTAR");
            for(int j = 10; j>=1; j--)
            {
                Console.WriteLine("Valores: " + j);
            }




            Console.ReadKey(); 
        }
    }
}
