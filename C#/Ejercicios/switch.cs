using System;

namespace ProyectoIntegradorModulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Opción 1");
            Console.WriteLine("2. Opción 2");
            Console.WriteLine("3. Opción 3");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");
            
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado la Opción 1.");
                    // Realiza acciones relacionadas con la Opción 1
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado la Opción 2.");
                    // Realiza acciones relacionadas con la Opción 2
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado la Opción 3.");
                    // Realiza acciones relacionadas con la Opción 3
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
                }
            }

        }
    }
}