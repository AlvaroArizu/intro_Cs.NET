using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            Console.WriteLine("Ingrese un nombre de no mas de 10 caracteres: ");
            nombre = Console.ReadLine();
            
            if(nombre.Length <= 10)
            {
                Console.WriteLine("Hola " + nombre + "!");
            }
            else
            {
                Console.WriteLine("El nombre ingresado contiene mas de 10 caracteres!");
            }
            Console.ReadKey();
        }
    }
}
