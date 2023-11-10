using System;

class Program
{
    static void Main()
    {
        // Declaración e inicialización de un vector de enteros
        int[] numeros = new int[5]; // Un vector de 5 elementos

        // Asignación de valores a los elementos del vector
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;

        // Acceso e impresión de elementos del vector
        Console.WriteLine("Elementos del vector:");
        Console.WriteLine("números[0] = " + numeros[0]);
        Console.WriteLine("números[1] = " + numeros[1]);
        Console.WriteLine("números[2] = " + numeros[2]);
        Console.WriteLine("números[3] = " + numeros[3]);
        Console.WriteLine("números[4] = " + numeros[4]);

        // Iteración a través de los elementos del vector
        Console.WriteLine("\nRecorriendo el vector:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("números[" + i + "] = " + numeros[i]);
        }
    }
}
