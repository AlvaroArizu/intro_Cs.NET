using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generar un programa que pide ingresar 4 variables (a, b, c, d).
            //Se pide:
            //1. Suma de todos las variables
            //2. Promedio de todas las variables
            //3. Porcentaje de a con referecnia a b
            //4. Porcentaje de a con referecia a las 4 variables (a, b, c, d)
            //INFORMAR LOS RESULTADOS USANDO IMPRESION POR INDICE 

            //_______________________________________________________________
            //Variables e ingreso de datos
            double a = 1, b = 2, c = 3, d = 4, suma = 0, promedio = 0, porceA = 0, porceTotal = 0;

            //Calculos
            suma = a + b + c + d;
            promedio = suma / 4;
            porceA = a * 100 / b;
            porceTotal = a * 100 / suma;

            //INFORMAR
            Console.WriteLine("_____INFORME_____");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);
            Console.WriteLine("Valor de C: " + c);
            Console.WriteLine("Valor de D: " + d);
            Console.WriteLine("_________________");
            Console.WriteLine("Suma de los 4 valores: " + suma);
            Console.WriteLine("Promedio de los 4 valores: "+ promedio);
            Console.WriteLine("Porcentaje de A con respecto de B: " + porceA + "%");
            Console.WriteLine("Porcentaje de A con respecto a los 4 valores: "+ porceTotal + "%");


            Console.ReadKey();
        }
    }
}
