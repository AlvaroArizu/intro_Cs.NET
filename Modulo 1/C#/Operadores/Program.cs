using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generar un progrma que pida ingresar: Nombre del producto, calidad, precio unitario.
            //Se pide informr: nombre del producto, subtotal, IVA21%, y el precio a pagar

            //Variables
            string nombre_producto;
            int cantidad;
            double precio;

            //Variables de calculo (Siempre se inicializan)
            double subtotal = 0, iva = 0, precio_pagar = 0;

            //Ingreso de datos
            Console.WriteLine("_____INGRESO DE DATOS_____"); //WriteLine es para salto de linea 
            Console.Write("Ingrese el nombre del producto: ");
            nombre_producto = Console.ReadLine();

            Console.Write("Ingrese la cantidad: ");
            cantidad = int.Parse(Console.ReadLine()); //Forma 1 de convertir el tipo de dato

            Console.Write("Ingrese el precio: "); //Forma 2 de convertir el tipo de dato
            precio = Convert.ToDouble(Console.ReadLine());


            //Calculos y datos a informar
            Console.WriteLine("_____DATOS INFORMADOS_____");
            Console.WriteLine("Nombre del producto: " + nombre_producto);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Precio: " + precio);
            subtotal = cantidad * precio;
            Console.WriteLine("El subtotal es: " + subtotal);

            iva = (subtotal * 21) / 100;
            Console.WriteLine("IVA: "+iva);

            precio_pagar = subtotal + iva;
            Console.WriteLine("PRECIO A PAGAR: "+precio_pagar);

            Console.ReadKey(); 
        }
    }
}
