using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxmIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Busqueda del nro max y del min de un array

            int[] vecValores = new int[4]; //CREO EL VECTOR

            
            vecValores[1] = 2;
            vecValores[2] = 3;
            vecValores[3] = 4;

            int max = vecValores[0], min = vecValores[0];
            //Recorremos desde la posicion 1, ya que el valor de la posicion 0 se asigno a max y min
            for(int i = 1; i<vecValores.Length; i++)
            {
                Console.WriteLine("Posicion [" + i + "]: " + vecValores[i]);

                if (vecValores[i] > max)
                {
                    max = vecValores[i];
                }else if (vecValores[i] < min)
                {
                    min = vecValores[i];
                }

            }
            Console.WriteLine("Max: "+ max);
            Console.WriteLine("Min: " + min);


            Console.ReadKey();
        }
    }
}
