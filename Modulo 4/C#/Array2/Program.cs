using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Carga un vector con 4 nombres e informar cuantas veces aparece el nombre carlos
             */
            String[] vecNombres = { "Juan", "Alvaro", "Pedro", "Ana", "Carlos" };
            
            for(int i = 0; i < vecNombres.Length; i++)
            {
                Console.WriteLine("Nombre ["+i+"]: "+vecNombres[i]);
                if (vecNombres[i] == "Carlos")
                {
                    Console.WriteLine("\nEn la posicion: [" + i + "] se encuentra el nombre: " + vecNombres[i]);
                }
                
            }

            Console.ReadKey();
        }
    }
}
