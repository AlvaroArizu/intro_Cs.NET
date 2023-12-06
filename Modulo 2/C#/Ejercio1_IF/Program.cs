using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio1_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar 5 notas por consola
            -1. Informar la suma
            -2. Promedio
            -3. Si el primedio es mayor o igual a 4, informar aprobado, sino desaprobado
             */
            double nota1, nota2, nota3,nota4, nota5, promedio = 0, suma = 0;
            Console.WriteLine("______INGRESO DE NOTAS______");
            Console.Write("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Nota 4: ");
            nota4 = double.Parse(Console.ReadLine());
            Console.Write("Nota 5: ");
            nota5 = double.Parse(Console.ReadLine());

            suma = nota1 + nota2 + nota3+nota4+nota5;
            promedio = suma/5;

            Console.WriteLine("_____INFORME DE NOTAS_____");

            Console.WriteLine("Nota 1: " + nota1);
            Console.WriteLine("Nota 2: " + nota2);
            Console.WriteLine("Nota 3: " + nota3);
            Console.WriteLine("Nota 4: " + nota4);
            Console.WriteLine("Nota 5: " + nota5);
            Console.WriteLine("Suma de las 5 notas: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Situacion: ");

            if (promedio >= 4)
            {
                Console.Write("APROBADO, Promedio: "+ Math.Round(promedio,2));
            }
            else
            {
                Console.Write("DESAPROBADO, Promedio: "+ Math.Round(promedio, 2));
            }

            Console.ReadKey();
        }
    }
}
