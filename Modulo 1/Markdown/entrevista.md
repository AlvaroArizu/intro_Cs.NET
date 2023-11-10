# Cuales son las diferencias entre una clase u una interfaz en C#?
### Una Clase
Es como una plantilla o molde que se usa para la creacion de objetos, cntiene la definicion de metodos, propiedades y constructor

Contiene un comportamiento predeterminado para los objetos que se van a crear

### Una Interfaz
Es un contrato o tipo abstracto que se utiliza para garantizar las propiedades y los metodos. 

Se usa para implementar patrones de diseño, principios de buenas practicas y pruebas unitarias

# Como se define el contructor de una clase en C#?
Es un metodo que no devuelve nada y se llama igual que la clase 
```cs
public class Person
{
    private string last;
    private string first;
    public Person(string lastname, string firstname)
    {
        last=lastName;
        first =firstName;
    }
    //Remainig implemetation of Person class
}
```
# Que son los modificadores de acceso y coo funciona, menciona 2 de ellos
Permiten especificar el alcance de clases, metodos y propiedades

- Public: puede accedido por donde entro y fuera del contexto
- Internal: Acceso por todos los componentes del Assembly
- Private: Solo puede ser accedido dentro del contexto

# Es posible heredar de multiples clases en C#?
Solo se puede heredar de una sola clas unicamente 
# Es posible implementar multiples interfaces en C#
Si, es posible y es una buena practica
# Mencionar 3 buenas practicas que apliques al escribir codigo C#
1. Nombramiento: asignar nombres claros y descriptivos a las variables, metodos y clases
2. Evitar enviar muchos paramentros a un metodo
3. Asignar una unica responsabilidad a cada componente en el codigo, aplicando los principios SOLID
# Ques es CRL
- Common Language Runtime
- Compila el codigo a un lenguaje intermedio comun
# Que es el garabage collector
1. Es un componente del CRL sirve para administrar la memoria de manera automatic
2. Libera la memoria de los componentes que no se usan en el sistema y provee una manera segura de administrarla
# Que es un mtodo virtual en C#
Significa que el metodo puede sobreescribirse lo cual permite aplicar el principio de polimorfismo
# Que es LINQ y como funciona
- Es un conjunto de extensiones que permite trabajar manipulacion de datos de una manera facil y simple
- Query expression y metodo de extension 
- Permite realizar operaciones osbre colleciones, mnimizar el codigo y mejorar el rendimiento 


