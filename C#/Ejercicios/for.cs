using System;

namespace ProyectoIntegradorModulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 8, 12, 4, 6 };
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }

            Console.WriteLine("Los números en el vector son:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine("\nLa suma de los números es: " + suma);
        }
    }
}