using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char seguir;
            int i, nro;

            do
            {
                Console.WriteLine("Ingrese un nro: ");
                nro = int.Parse(Console.ReadLine());

                //Impresion por indice
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine(" {0} * {1} = {2}", i, nro, i * nro);
                }

                Console.WriteLine("Desea agregar mas datos?(S/N): ");
                seguir = Convert.ToChar(Console.ReadLine().ToUpper().Substring(0, 1));

            } while (seguir!='n');



            Console.ReadKey();
        }
    }
}
