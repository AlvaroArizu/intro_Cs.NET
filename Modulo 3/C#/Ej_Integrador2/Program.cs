using System;

namespace Ej_Integrador2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadModelos;
            double cantReg = 0, cantM = 0, cantH = 0, cantRegP = 0, cantRegN = 0;
            double promedioEdadesM = 0, promedioEdadesH = 0, porcentajeHp = 0, porcentajeHn = 0, porcentajeMp = 0, porcentajeMn = 0, promedioEdades;

            Console.WriteLine("Ingrese la cantidad de modelos a registrar: ");
            cantidadModelos = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadModelos; i++)
            {
                string nombre, apellido, sexo;
                int edad, peso, estatura;

                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido: ");
                apellido = Console.ReadLine();
                Console.WriteLine("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese peso: ");
                peso = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese estatura: ");
                estatura = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese sexo (M o H): ");
                sexo = Console.ReadLine().ToUpper().Substring(0, 1);

                if ((sexo == "M" || sexo == "H") && edad <= 25 && estatura >= 170 && peso < 70)
                {
                    cantRegP++;
                }
                else
                {
                    cantRegN++;
                }

                switch (sexo)
                {
                    case "M":
                        cantM++;
                        promedioEdadesM = ((promedioEdadesM * (cantM - 1)) + edad) / cantM;
                        break;
                    case "H":
                        cantH++;
                        promedioEdadesH = ((promedioEdadesH * (cantH - 1)) + edad) / cantH;
                        break;
                    default:
                        Console.WriteLine("Sexo inválido");
                        break;
                }

                cantReg++;
            }

            porcentajeMp = (cantRegP / cantReg) * 100;
            porcentajeMn = (cantRegN / cantReg) * 100;
            porcentajeHp = (cantH / cantReg) * 100;
            porcentajeHn = (cantM / cantReg) * 100;

            Console.WriteLine("___Resultados___");
            Console.WriteLine("Cantidad de registros: " + cantReg);
            Console.WriteLine("Cantidad de registros Hombres: " + cantH);
            Console.WriteLine("Cantidad de registros Mujeres: " + cantM);
            Console.WriteLine("Promedio de edades Hombres: " + promedioEdadesH);
            Console.WriteLine("Promedio de edades Mujeres: " + promedioEdadesM);
            Console.WriteLine("Porcentaje de Hombres Aceptados: " + porcentajeHp + "%");
            Console.WriteLine("Porcentaje de Mujeres Aceptadas: " + porcentajeMp + "%");
            Console.WriteLine("Porcentaje de Hombres No Aceptados: " + porcentajeHn + "%");
            Console.WriteLine("Porcentaje de Mujeres No Aceptadas: " + porcentajeMn + "%");
            Console.WriteLine("CANTIDAD DE MODELOS CONTRATADOS: " + cantRegP);
            Console.WriteLine("CANTIDAD DE MODELOS NO CONTRATADOS: " + cantRegN);

            Console.ReadKey();
        }
    }
}
