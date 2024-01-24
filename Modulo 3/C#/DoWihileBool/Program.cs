using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWihileBool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, opcion;
            bool otro;

            do
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Desea agregar mas datos?(S/N): ");
                opcion = Console.ReadLine().ToUpper().Substring(0,1);

                if(opcion == "S" || opcion=="s")//con el .ToUpper(), no hace falta poner opcion=="s"
                {
                    otro = true;
                }
                else
                {
                    otro= false;
                    Console.WriteLine("Salio del programa!!");
                }

            } while (otro);
            

            Console.ReadKey();
        }
    }
}
