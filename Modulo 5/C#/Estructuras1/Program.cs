using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras1
{
    internal class Program

    {
        //CUERPO DE LA ESTRUCTURA
        public struct TipoPersona
        {
            // Visibilidad - TipoDato - Nombre
           // public            int         id;

            //MIEMBROS
            public string name;
            public int age;
            public string surname;
        }
        static void Main(string[] args)
        {
            //Instanciacion de la estructura
            TipoPersona per1;
            TipoPersona per2;

            per1.name = "Alvaro";
            per1.surname = "Arizu";
            per1.age = 23;

            per2.name = "Martina";
            per2.surname = "Vazquez";
            per2.age = 23;

            Console.WriteLine("____DATOS ESTRUCTURA 1____");
            Console.WriteLine("Nombre: {0}", per1.name);
            Console.WriteLine("Apellido: {0}", per1.surname);
            Console.WriteLine("Edad: {0}", per1.age);

            Console.WriteLine("\n____DATOS ESTRUCTURA 2____");
            Console.WriteLine("Nombre: "+ per2.name);
            Console.WriteLine("Apellido: "+per2.surname);
            Console.WriteLine("Edad: "+per2.age);


            Console.ReadKey();
        }


    }
    }
}
