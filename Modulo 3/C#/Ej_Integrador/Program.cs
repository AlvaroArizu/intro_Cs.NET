using System;

namespace Ej_Integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, sexo, nombreM, apellidoM;
            long dni;
            int cantH = 0, cantM = 0, cantM30 = 0, cantH20y50 = 0, cantReg = 0, edad, sumaEdadesM = 0, sumaEdadesH = 0, sumaEdades = 0;
            double promedioEdades = 0, promedioEdadesSexo = 0, promedioEdadesM = 0, promedioEdadesH = 0, porcentajeH = 0, porcentajeM = 0;

            Console.WriteLine("Ingrese el DNI: ");
            dni = long.Parse(Console.ReadLine());

            while (dni != 0)
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                nombreM = nombre.ToLower();

                Console.WriteLine("Ingrese su apellido: ");
                apellido = Console.ReadLine();
                apellidoM = apellido.ToLower();

                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());

                nuevo: 
                Console.WriteLine("Ingrese el sexo (M o H): ");
                sexo = Console.ReadLine().Substring(0, 1).ToUpper();

                switch (sexo)
                {
                    case "M":
                        cantM++;
                        if (edad >= 30)
                        {
                            cantM30++;
                        }
                        sumaEdadesM += edad;
                        promedioEdadesM = (double)sumaEdadesM / cantM;
                        break;
                    case "H":
                        cantH++;
                        if (edad >= 20 && edad <= 50)
                        {
                            cantH20y50++;
                        }
                        sumaEdadesH += edad;
                        promedioEdadesH = (double)sumaEdadesH / cantH;
                        break;
                    default:
                        Console.WriteLine("Sexo inválido");
                        goto nuevo;
                        //break;
                }

                cantReg++;
                sumaEdades = sumaEdadesM + sumaEdadesH;
                promedioEdades = (double)sumaEdades / cantReg;

                porcentajeM = (cantM * 100.0) / cantReg;
                porcentajeH = (cantH * 100.0) / cantReg;

                Console.WriteLine("Ingrese el DNI: ");
                dni = long.Parse(Console.ReadLine());
            }

            Console.WriteLine("___Resultados___");
            Console.WriteLine("Cantidad de registros: " + cantReg);
            Console.WriteLine("Cantidad de registros Hombres: " + cantH);
            Console.WriteLine("Cantidad de registros hombres entre 20 y 50 años: " + cantH20y50);
            Console.WriteLine("Cantidad de registros Mujeres: " + cantM);
            Console.WriteLine("Cantidad de registros Mujeres +30 años: " + cantM30);
            Console.WriteLine("Promedio de edades Hombres: " + promedioEdadesH);
            Console.WriteLine("Promedio de edades Mujeres: " + promedioEdadesM);
            Console.WriteLine("Porcentaje de Hombres: " + porcentajeH+"%");
            Console.WriteLine("Porcentaje de Mujeres: " + porcentajeM+"%");

            Console.ReadKey();
        }
    }
}
