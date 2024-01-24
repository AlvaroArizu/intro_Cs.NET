using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura3
{
    internal class Program
    {
        //Estructuras
        public struct Estudiante
        {
            public string name;
            public string surname;
            public int matricula;
            public double nota1, nota2;
        }
        static void Main(string[] args)
        {
            // Variables 
            int n;
            double suma = 0, prom = 0;
            string notaFinal="";


            //Estructuras y vectores
            Estudiante[] este1 = new Estudiante[4];
            Console.Write("Ingrese la cantidad de alumnos a cargar: ");
            n = int.Parse(Console.ReadLine());
            //Carga de datos
            for(int i=0; i<n; i++)
            {
                Console.Write("Ingrese el nombre del alumno: ");
                este1[i].name= Console.ReadLine();

                Console.Write("Ingrese el apellido del alumno: ");
                este1[i].surname = Console.ReadLine();

                Console.Write("Ingrese el nro de matricula: ");
                este1[i].matricula = int.Parse(Console.ReadLine());

                Console.Write("Nota 1: ");
                este1[i].nota1 = double.Parse(Console.ReadLine());

                Console.Write("Nota 2: ");
                este1[i].nota2 = double.Parse(Console.ReadLine());

                suma = este1[i].nota1 + este1[i].nota2;
                prom = suma / 2;

                if (prom >= 7)
                {
                    notaFinal = "Promociono la materia";
                }
                else if(prom>=4 && prom<7)
                {
                    notaFinal = "Rinde Final";
                }
                else
                {
                    notaFinal = "Recursa la materia";
                }

                Console.WriteLine("_____RESULTADOS_____");
                Console.WriteLine("Promedio: {0}", prom);
                Console.WriteLine("Situacion academica: {0}", notaFinal);
            }
            

            Console.ReadKey();
        }
    }
}
