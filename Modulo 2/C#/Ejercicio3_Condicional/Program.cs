using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar 2 notas, calcular el promedio e informar el siguiente mensaje:
            _0-4 Desaprobado
            _4-7 Aprobado
            _7-9 Muy bien
            _10 Excelente
            _SINO Nota invalida
             */
            string apellido= "Arizu";
            double nota1, nota2, promedio = 0, suma = 0;
            Console.WriteLine("______INGRESO DE NOTAS______");
            Console.Write("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            suma = nota1 + nota2;
            promedio = suma / 2;

            if(promedio>0 && promedio < 4)
            {
                Console.Write("Apellido: "+ apellido+", Desaprobado, Promedio: " + Math.Round(promedio, 2));
            }else
            {
                if (promedio > 4 && promedio < 7)
                {
                    Console.Write("Apellido: " + apellido + ", Aprobado, Promedio: " + Math.Round(promedio, 2));
                }else
                {
                    if (promedio > 7 && promedio < 9)
                    {
                        Console.Write("Apellido: " + apellido + ", Aprobado MUY BIEN, Promedio: " + Math.Round(promedio, 2));
                    }else
                    {
                        if (promedio == 10)
                        {
                            Console.Write("Apellido: " + apellido + ", Aprobado EXCELENTE, Promedio: " + Math.Round(promedio, 2));
                        }
                        else
                        {
                            Console.Write("NOTA INVALIDA");
                        }
                    }
                }
            }
            Console.ReadKey();  
        }
    }
}
