using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Generar un programa que pida ingresar los siguientes datos:
            -DNI
            -NOMBRE EN MAYUSCULA
            -APELLIDO EN MAYUSCULA
            -SEXO (H: HOMBRE, M:MUJER)
            
            Se deja ingresar datos con DNI distinto de 0
            Se pide informar: 
            -Cantidad de registros
            -Cant de M
            -Cant de H
            -Cant de M +30 años
            -Cant de H entre 20 y 50 años
            -Promedio de edades
            -Proemdio de edades por sexo
            -Porcentaje de mujeres y varones
             */

            //Variables
            string nombre, apellido, sexo, nombreM, apellidoM;
            long dni;
            int cantH = 0, cantM = 0, cantM30 = 0, cantH20y50 = 0, cantReg=0;
            double promedioEdades = 0, promedioEdadesSexo = 0, porcentajeHyM = 0;

            Console.WriteLine("Ingrese el DNI: ");
            dni = long.Parse(Console.ReadLine());

            while (dni != 0)
            {
                cantReg++;
                Console.WriteLine("Ingrese su nombre: ");
                nombre= Console.ReadLine();
                nombreM= nombre.ToLower();

                Console.WriteLine("Ingrese su apellido: ");
                apellido = Console.ReadLine();
                apellidoM = apellido.ToLower();

                Console.WriteLine("Ingrese el sexo (H:Hombre - M:Mujer): ");
                sexo = Console.ReadLine();
                if(sexo != 'H')
                {
                    cantH++;
                }else
                {
                    cantM++;
                }

            }



        }
    }
}
