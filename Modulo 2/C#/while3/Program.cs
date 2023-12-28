using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES DE CADENA 
            string cadena = "álvaro maría arizu riportella";

            //TRANSFORMA EN MAYUSCULA
            string mayusculas = cadena.ToUpper();
            Console.WriteLine("Cadena en mayuscula: " + mayusculas);

            //TRANSFORMA EN MINUSCULA
            string minuscuas = cadena.ToLower();
            Console.WriteLine("Cadena en minusculas: " + minuscuas);

            //CUENTA CARACTERES
            int cantCarac = cadena.Length;
            Console.WriteLine("Cantidad de caracteres de la cadena: " + cantCarac);

            //Extraer palabras de la cadena (POSICION Y CANTIDAD)
            string extraer = cadena.Substring(5, 5).ToUpper(); //HAY 2 CADENAS
            Console.WriteLine("La palabra que esta en la posicion 5, en cantidad de 5 es: " + extraer);

            // Posicion de lo que busco 
            int primeraLetra=cadena.IndexOf('a');
            Console.WriteLine("La posicion de la letra [e] es: " + primeraLetra);

            //UTLIMA LETRA
            int ultimaLetra = cadena.LastIndexOf("a");
            Console.WriteLine("La palabra de la ultima letra es: " + ultimaLetra);

            Console.ReadKey();
        }
    }
}
