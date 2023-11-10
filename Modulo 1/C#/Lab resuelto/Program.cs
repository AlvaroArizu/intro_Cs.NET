using System;

namespace DescargaLaboratoriosModulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////
            // Resolución del laboratorio adicional 1 - Asignación básica y compacta
            ///////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("LABORATORIO 1 - Ejercicio 1 - Asignación básica");
            Console.WriteLine("");

            Console.WriteLine("A");
            int x = 10;
            int y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nB");
            x = x + 5;
            y = y + 10;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nC");
            x = x - 5;
            y = y - 10;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nD");
            x = x * 3;
            y = y * 5;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nE");
            x = x / 2;
            y = y / 4;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("LABORATORIO 1 - Ejercicio 2 - Asignación compacta");
            Console.WriteLine("");

            Console.WriteLine("A");
            //Instrucción de la diapositiva, se modifica por asignación de variables dado que están definidas anteriormente
            // int x = 10
            // int y = 20;
            x = 10;
            y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nB");
            x += 5;
            y -= 15;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nC");
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nD");
            x *= 4;
            y *= -3;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nE");
            x /= 2;
            y /= 4;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            ////////////////////////////////////////////////////////////////////////////////
            // Resolución del laboratorio adicional 2 - Operadores aritméticos
            ////////////////////////////////////////////////////////////////////////////////           
            Console.WriteLine("LABORATORIO 2 - Ejercicio 1 - Operadores aritméticos");
            Console.WriteLine("");
            
            Console.WriteLine("A");
            //Instrucción de la diapositiva, se modifica por asignación de variables dado que están definidas anteriormente
            //int x = 10;
            //int y = 20;
            x = 10;
            y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nB");
            x = x + y;
            y = y + x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nC");
            x = x - y;
            y = y - x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nD");
            x = x * y;
            y = x * x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nE");
            x = y / x;
            y = x / y;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("LABORATORIO 2 - Ejercicio 2 - Operadores aritméticos con asignación compacta");
            Console.WriteLine("");

            Console.WriteLine("A");
            //Instrucción de la diapositiva, se modifica por asignación de variables dado que están definidas anteriormente
            //int x = 5;
            //int y = 10;
            x = 5;
            y = 10;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nB");
            x += y;
            y += x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nC");
            x -= y;
            y -= x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nD");
            x *= y;
            y *= x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("\nE");
            x /= y;
            y /= y;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("LABORATORIO 2 - Ejercicio 3 - Operadores Aritméticos con asignación múltiple(suma y resta)");
            Console.WriteLine("");

            Console.WriteLine("A");
            //Instrucción de la diapositiva, se modifica por asignación de variables dado que están definidas anteriormente
            //int x = 5;
            //int y = 10;
            x = 5;
            y = 10;
            int suma = 0;
            int resta = 0;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(suma);
            Console.WriteLine(resta);

            Console.WriteLine("\nB");
            suma = x + y;
            resta = x - y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(suma);
            Console.WriteLine(resta);

            Console.WriteLine("\nC");
            suma = x + x;
            resta = y - y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(suma);
            Console.WriteLine(resta);

            Console.WriteLine("\nD");
            suma = x + y + x;
            resta = x - x - 20;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(suma);
            Console.WriteLine(resta);

            Console.WriteLine("\nE");
            suma = y + x + x;
            resta = -x - y - y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(suma);
            Console.WriteLine(resta);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("LABORATORIO 2 - Ejercicio 4 - Operadores Aritméticos con asignación múltiple(producto y división)");
            Console.WriteLine("");

            Console.WriteLine("A");
            //Instrucción de la diapositiva, se modifica por asignación de variables dado que están definidas anteriormente
            //int x = 5;
            //int y = 10;
            x = 5;
            y = 10;
            int multi = 1;
            int division = 1;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(multi);
            Console.WriteLine(division);

            Console.WriteLine("\nB");
            multi = x * y;
            division = x / y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(multi);
            Console.WriteLine(division);

            Console.WriteLine("\nC");
            multi = x * x;
            division = y / y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(multi);
            Console.WriteLine(division);

            Console.WriteLine("\nD");
            multi = x * y * x;
            division = y / x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(multi);
            Console.WriteLine(division);

            Console.WriteLine("\nE");
            multi = x * (-y);
            division = y / (-x);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(multi);
            Console.WriteLine(division);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("LABORATORIO 2 - Ejercicio 5 - Operador Resto");
            Console.WriteLine("");

            Console.WriteLine("A");
            int n1 = 20;
            int n2 = 2;
            int n3 = n2 % n1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            Console.WriteLine("\nB");
            n1 = 15;
            n2 = 2;
            n3 = n1 % n2;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            Console.WriteLine("\nC");
            n1 = 3;
            n2 = 20;
            n3 = n2 % n1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            Console.WriteLine("\nD");
            n1 = 3;
            n2 = 15;
            n3 = n2 % n1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("LABORATORIO 2 - Ejercicio 6 - Cadenas de Caracteres");
            Console.WriteLine("");

            Console.WriteLine("A");
            String palabra_1 = "Hola";
            String palabra_2 = "Mundo";
            String frase = "";
            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);

            Console.WriteLine("\nB");
            frase = palabra_1 + palabra_2;
            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);

            Console.WriteLine("\nC");
            frase = palabra_1 + " \t " + palabra_2;
            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);

            Console.WriteLine("\nD");
            frase = palabra_1 + " \n " + palabra_2;
            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);

            Console.WriteLine("\nE");
            frase = palabra_1 + " \n \t " + palabra_2;
            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("LABORATORIO 2 - Ejercicio 7 - Operadores Lógicos");
            Console.WriteLine("");

            Console.WriteLine("A");
            // Se modifica nombres de variables n... por v... dada colisión con definición anterior de variables
            bool v1 = true;
            bool v2 = false;
            bool v3 = !v1;
            bool v4 = !v2;
            Console.WriteLine(v3);
            Console.WriteLine(v4);

            Console.WriteLine("\nB");
            v3 = v1 & v2;
            v4 = v1 | v2;
            Console.WriteLine(v3);
            Console.WriteLine(v4);

            Console.WriteLine("\nC");
            v3 = !(v1 & v2);
            v4 = !(v1 | v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);

            Console.WriteLine("\nD");
            v3 = !v1 & v2;
            v4 = !v1 | v2;
            Console.WriteLine(v3);
            Console.WriteLine(v4);

            Console.WriteLine("\nE");
            v3 = v1 ^ v2;
            v4 = v1 ^ !v2;
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            ////////////////////////////////////////////////////////////////////////////////
            // Resolución del laboratorio adicional 3 - Operadores y Comentarios
            ////////////////////////////////////////////////////////////////////////////////           
            Console.WriteLine("LABORATORIO 3 - Ejercicio 1");
            Console.WriteLine("");

            //Instrucción de la diapositiva, se modifica por asignación de variables dado que están definidas anteriormente
            //int n1 = 5, n2 = 10, n3 = 20;
            n1 = 5;
            n2 = 10;
            n3 = 20;

            Console.WriteLine("Contenido de las variables para realizar las operaciones aritméticas: ");
            Console.WriteLine($"n1 tiene {n1}, n2 tiene {n2} y n3 tiene {n3}");
            Console.WriteLine("");

            Console.WriteLine("Resultado de las operaciones aritméticas: ");
            Console.WriteLine("n1+n2= " + (n1 + n2));
            Console.WriteLine("n3-n1= " + (n3 - n1));
            Console.WriteLine("n1*n3= " + n1 * n3);
            Console.WriteLine("n3/n2= " + n3 / n2);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

            Console.WriteLine("LABORATORIO 3 - Ejercicio 2");
            Console.WriteLine("");

            //int n1 = 10, n2 = 20, n3 = 30;    //Instrucción de la diapositiva, se modifica por asignación de variables dado que están definidas anteriormente
            n1 = 10;
            n2 = 20;
            n3 = 30;
            Console.WriteLine("Se modifica el contenido de las variables para realizar los siguientes cálculos: ");
            Console.WriteLine($"n1 tiene {n1}, n2 tiene {n2} y n3 tiene {n3}");
            Console.WriteLine("");

            int total = n1 + n2 + n3;
            double promedio = total / 3;
            int resto = n2 % n1;

            Console.WriteLine("total = n1 + n2 + n3 da como resultado " + total);
            Console.WriteLine("promedio = total / 3 da como resultado " + promedio);
            Console.WriteLine("resto = n2 % n1 da como resultado " + resto);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();

        }
    }
}
