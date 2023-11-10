using System;

namespace ProyectoIntegradorModulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al proyecto integrador Etapa 2");

            string Nombre;      // aquí defino una variable (espacio de memoria) para guardar caracteres
            string Apellido;
            string Email;
            char Respuesta;
            int Edad;
            int CodigoCarrera;
            string CarreraSeleccionada="";

            //carga de datos
            Console.Write("Ingresá tu nombre: ");
            Nombre = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingresá tu apellido: ");
            Apellido = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingresa tu edad: ");
            Edad = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingresa tu email: ");
            Email = Console.ReadLine();
            Console.Clear();

            //muestra datos cargados
            Console.WriteLine("<<<< Datos del alumno >>>>");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Email: " + Email);

            // empieza bifurcacion
            Console.WriteLine("¿Los datos son correctos? - 'S' para confirmar 'N' para cancelar");
            Respuesta = char.Parse(Console.ReadLine());

            if (Respuesta == 's' || Respuesta == 'S')
            {
                //Puedo solicitar el código de carrera
                Console.Clear();
                Console.WriteLine("<<<< Seleccioná el código de la carrera elegida: >>>>");
                Console.WriteLine("1. Programación .Net");
                Console.WriteLine("2. Programación Java");
                Console.WriteLine("3. Programación PHP");
                CodigoCarrera = Convert.ToInt32(Console.ReadLine());

                if (CodigoCarrera == 1 || CodigoCarrera == 2 || CodigoCarrera == 3)
                {
                    Console.WriteLine("<<<< Constancia de inscripción: >>>>");
                    Console.WriteLine("Alumno: " + Nombre + " " + Apellido);
                    Console.WriteLine("Correo electrónico: " + Email);


                    switch (CodigoCarrera)
                    {
                        case 1:
                            CarreraSeleccionada = "Programación .Net";
                            break;
                        case 2:
                            CarreraSeleccionada = "Programación Java";
                            break;
                        case 3:
                            CarreraSeleccionada = "Programación PHP";
                            break;
                    }
                    Console.WriteLine("Carrera: " + CarreraSeleccionada);
                }
                else
                {
                    Console.WriteLine("Carrera inexistente");
                    Console.WriteLine("Datos incorrectos. Ejecutar nuevamente la aplicación.");
                }
            }
            else
            {
                Console.WriteLine("Datos incorrectos. Ejecutar nuevamente la aplicación.");
            }
            Console.ReadKey();
        }
    }
}


/*

Esta etapa deberá incluir: Declaración e
inicialización de variables, uso de estructuras
condicionales y salida de datos por pantalla.
1. Realizar una interfaz que solicite al alumno:
● Nombre.
● Apellido.
● Edad.
● Correo electrónico.

2. Una vez cargados estos 4 datos, mostrar
los datos ingresados y pedir al alumno una
confirmación para saber si los datos son
correctos. Si se confirman los datos, deberá
solicitar al alumno que seleccione un código
de carrera. En caso contrario, pedir que
ejecute nuevamente la aplicación y finalizará.

3. Mostrar por pantalla un mensaje con los
datos personales del alumno y la carrera
elegida.

4. En caso de que el código de la carrera
seleccionado sea incorrecto, mostrar un mensaje de
error notificando que la carrera es inexistente,
y solicite al alumno que vuelva a iniciar la
aplicación finalizando su ejecución.

 */



