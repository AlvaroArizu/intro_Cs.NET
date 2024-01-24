using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones1
{
    internal class Program
    {
        //CREACION DE UN PROCEDIMIENTO
        static void ProcedimientoPar(int n)
        {
            //Variable local
            int resultado;
            resultado = n % 2;

            if(resultado == 0)
            {
                Console.WriteLine("El Nro ingresado {0} es par", n);
            }
            else
            {
                Console.WriteLine("El Nro ingresado {0} es impar", n);
            }

        //CREACION DE UNA FUNCION 
        static double Sumar(double n1, double n2)
            {
                return n1 + n2;
            }

        }
        static void Main(string[] args)
        {
            double nro1, nro2, resu = 0;
            int nro;
            Console.Title = "USO DE PROCEDIMIENTOS Y FUNCIONES";

            Console.WriteLine("PROCEDIMIENTOS");
            Console.Write("Ingrese nros: ");
            nro = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFUNCIONES");
            Console.Write("Ingrese nros: ");
            nro1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese nros: ");
            nro2 = double.Parse(Console.ReadLine());

            //Invocacion-Instasiar un procedieminto (ProcedimientoPar)
            ProcedimientoPar(nro);

            //Invocacion de la funcion

            //FORMA 1
            Console.WriteLine("Resultado de la suma es: " + Sumar(nro1, nro2));

            //FORMA 2
            resu = Sumar(nro1, nro2);
            Console.WriteLine("Resultado de la suma es: " + resu);

            Console.ReadKey();
        }
    }
}
