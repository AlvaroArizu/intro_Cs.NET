using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Anidada
{
    internal class Program
    {
        //Estrucrturas anidadas
        public struct FechaNacimiento
        {
            public int dia;
            public int mes;
            public int anio;
        }

        public struct TipoPersona
        {
            public string name;
            public string surname;
            public FechaNacimiento datos;
        }
        static void Main(string[] args)
        {
            //Instanciado la estructura
            TipoPersona per1;
            TipoPersona per2;

            per1.name = "Alvaro";
            per1.surname = "Arizu";
            per1.datos.dia = 07;
            per1.datos.mes = 12;
            per1.datos.anio = 2000;

            per2.name = "Martina";
            per2.surname = "Vazquez";
            per2.datos.dia = 22;
            per2.datos.mes = 08;
            per2.datos.anio = 2000;

            Console.WriteLine("____DATOS ESTRUCTURA 1____");
            Console.WriteLine("Nombre: {0}", per1.name);
            Console.WriteLine("Apellido: {0}", per1.surname);
            Console.WriteLine("Fecha de nacimiento: {0}/{1}/{2}", per1.datos.dia, per1.datos.mes, per1.datos.anio);

            Console.WriteLine("\n____DATOS ESTRUCTURA 2____");
            Console.WriteLine("Nombre: " + per2.name);
            Console.WriteLine("Apellido: " + per2.surname);
            Console.WriteLine("Fecha de nacimiento: {0}/{1}/{2}", per2.datos.dia, per2.datos.mes, per2.datos.anio);


            Console.ReadKey();

        }
    }
}
