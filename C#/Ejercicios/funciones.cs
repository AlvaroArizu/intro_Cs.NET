using System;

class Program
{
    // Definición de una función que suma dos números
    static int Sumar(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }

    // Definición de una función que muestra un saludo
    static void Saludar(string nombre)
    {
        Console.WriteLine("Hola, " + nombre + "!");
    }

    static void Main()
    {
        // Llamando a la función Sumar y almacenando el resultado en una variable
        int resultadoSuma = Sumar(5, 3);
        Console.WriteLine("El resultado de la suma es: " + resultadoSuma);

        // Llamando a la función Saludar
        Saludar("Juan");
    }
}
