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