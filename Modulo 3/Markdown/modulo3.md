# Modulo 3
- Do-while
- For
- Break
- Continue
- Return 
- Goto
- Arreglos

## Do-While
La instrucción do...while es una variante del while y se usa así:
```cs
do{
    <INTRUCCIONES >
}While(<CONDICION>)
```
La diferencia clave entre `do...while` y `while` es el momento en que se evalúa la condición: do...`while` ejecuta las instrucciones al menos una vez antes de verificar la condición, mientras que `while` primero verifica la condición antes de ejecutar las instrucciones. Ambas permiten el uso de break y continue. El do...`while` se usa cuando se necesita ejecutar las instrucciones al menos una vez, incluso si la condición es falsa desde el principio.

```cs 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DoWhile
{
class VerificaPass
    {
       static void Main(string[] args)
      {
       string password;
do {
             Console.WriteLine("Ingrese la password: ");
             password = Console.ReadLine();
      } while (password != "1234");
       Console.WriteLine("Bienvenido !!!");
       Console.ReadKey();
      }
} }
```
`Este programa solicita al usuario una clave y, mientras no introduzca la clave correcta (1234), no continuará ejecutándose. Una vez que la clave sea introducida correctamente, el programa dará un mensaje de bienvenida al usuario.`

## For
La instrucción "for" se compone de `tres partes`: la `inicialización`, la `condición `y la `modificación`. 

Comienza ejecutando la inicialización, que generalmente define e inicializa variables. Luego evalúa la condición: si es falsa, sale del ciclo; si es verdadera, ejecuta las instrucciones indicadas. Después de las instrucciones, se ejecuta la modificación para alterar las variables utilizadas, y se reevalúa la condición. Este proceso continúa hasta que la condición deje de ser verdadera.

La instrucción for ejecuta un ciclo durante un número determinado de veces.

Consta de tres partes:
- La sección de inicialización, que se ejecuta al comienzo del ciclo.
- La condición, que se evalúa al entrar al ciclo y luego al comienzo de cada iteración.
- La sección de modificación, que se ejecuta al final de cada iteración, y previene que no se produzca un ciclo infinito (se ejecuta al final de cada iteración).
Su sintaxis es:
```cs
for(<inicialización>; <condición>; <modificación>) {
    <INTRUCCIONES>
}
```
El "for" permite inicializar múltiples instrucciones, evaluar una condición y modificar valores en un ciclo. En la sección de inicialización, se pueden usar varias instrucciones separadas por comas. En la sección de modificación, se pueden agregar instrucciones no relacionadas con modificaciones, pero no definir variables nuevas. Las variables definidas en la inicialización solo son visibles dentro de las instrucciones. El código presentado con "for" es equivalente al ejemplo previo con "while", siendo una forma más compacta de escribirlo.


```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace For
{
       class NumerosHasta5
       {
       static void Main(string[] args)
        {
             for (int numero = 1; numero <= 5; numero++)
{
                    Console.WriteLine(numero);
            }
             Console.ReadKey();
} }
}
```
`Al igual que con while, dentro de las <instrucciones> del for también es posible incluir instrucciones continue; y break; que puedan alterar el funcionamiento normal del ciclo.`

## Break 
La instrucción break sólo se puede incluir dentro de bloques de instrucciones asociados a instrucciones iterativas o instrucciones switch, e indica que se desea abortar la ejecución de las mismas y seguir ejecutando a partir de la instrucción siguiente
a ellas.

```cs
break;
```
```cs
static void Break_Ejemplo()
{
}
for (int numero = 2; numero <= 30; numero += 2)
      {
            Console.WriteLine(numero);
            if (numero == 20)
            {
                   Console.WriteLine("Llegó a 20 y salió con Break.");
break; }
 }
 Console.WriteLine("Aquí salió con el break");
```
En contexto de un bloque "try" con cláusula "finally", al ocurrir un error en tiempo de ejecución, antes de abortar la instrucción iterativa o el switch que la contiene, se ejecutarán las instrucciones en el bloque "finally" del "try". Esto garantiza que el bloque "finally" se ejecute incluso si hay un salto de ejecución. Si se usa "break" dentro del "finally" en un switch o instrucción iterativa, no se permite que el "break" interrumpa la ejecución del "finally"

## Continue
La instrucción llamada
continue sólo puede usarse dentro del bloque de instrucciones de una instrucción iterativa. Indica que se desea pasar a reevaluar directamente la condición de la iteración sin ejecutar el resto de instrucciones que contiene.

La evaluación de la condición se haría de la forma habitual: si es cierta se repite el ciclo y si es falsa se continúa ejecutando por la instrucción que le sigue.
Su sintaxis de uso es así de sencilla:
```cs
continue;
```
```cs
static void Continue_Ejemplo()
{
      for (int numero = 2; numero <= 30; numero += 2)
      {
            Console.WriteLine(numero);
            if (numero == 20)
            {
}
} }
Console.WriteLine("con Continue vuelve a ingresar al ciclo. No sale nunca");
numero = 8;
continue;
```
En cuanto a sus usos dentro de sentencias try, tiene las mismas restricciones que break: antes de salir de un try se ejecutará siempre su bloque finally y no es posible salir de un finally incluido dentro de una instrucción iterativa como consecuencia de un continue.

## Return 
Esta instrucción se usa para indicar cuál es el objeto que ha de devolver una función. Su sintaxis es la siguiente:
```cs
return <objetoRetorno>;
```
El "return" aborta la ejecución de la función y devuelve el objeto especificado, que debe coincidir con el tipo de retorno de la función o ser compatible con él. Esta instrucción solo se usa en funciones con un tipo de retorno distinto de "void", incluyendo bloques "get" de propiedades o indizadores. En funciones "void", se puede utilizar un "return" especial para indicar la terminación de la función sin devolver un valor específico.
```cs
static int Return_Ejemplo_Funcion()
      {
      int numero1 = 10, numero2 = 20;
      retur nnumero1 + numero2;

```
```cs
static void Return_Ejercicio4()
      {
      for (int numero = 2; numero <= 30; numero += 2)
            {
            Console.WriteLine(numero);
            if (numero == 20)
                {
                   Console.WriteLine("Sale con Return.....");
return; }
} }
```
El "return" dentro de un bloque "try" con cláusula "finally" ejecuta las instrucciones del "finally" antes de devolver el objeto. En bloques "finally" anidados, se ejecutan en orden, del más interno al más externo. No es posible incluir un "return" dentro de un "finally".

# Goto
a instrucción goto permite pasar a ejecutar el código a partir de una instrucción cuya etiqueta se indica en el goto. La sintaxis de uso de esta instrucción es:
```cs
goto <etiqueta>;
```
Como en la mayoría de los lenguajes, goto es
una instrucción nada recomendable cuyo uso dificulta innecesariamente la legibilidad del código y suele ser fácil de simular usando instrucciones iterativas y selectivas con las condiciones apropiadas.

Sin embargo, en C# se incluye porque puede ser eficiente usarla si se anidan muchas instrucciones y para reducir sus efectos negativos se le han impuesto unas restricciones. Vamos a ver estas restricciones en el próximo slide.

`Esta instrucción mal utilizada puede provocar complejos errores de lógica en la programación!`

- Sólo se pueden etiquetar instrucciones, y no directivas de preprocesado, directivas using o definiciones de miembros, tipos o espacios de nombres.
- La etiqueta indicada no pueda pertenecer a un bloque de instrucciones anidado dentro del bloque desde el que se usa el goto ni que etiquete a instrucciones de otro método diferente a aquél en el cual se encuentra el goto que la referencia.
- Para etiquetar una instrucción de modo que pueda ser destino de un salto con goto basta precederla del nombre con el que se la quiera etiquetar seguido de dos puntos (:).

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GOTO
{
class SalirGOTO
{
      static void Main(string[] args)
      {
            for (int numero = 1; numero <= 5; numero++)
            {
                  if (numero <= 3)
                  {
                        Console.WriteLine(numero); 
                  }
          else
          {
          goto salida;
          }
}
    salida: Console.WriteLine("Llegó a 3 e interrumpió la ejecución del for");
    Console.ReadKey();
}
} }
```
El programa anterior muestra números del 1 al 5 y se detiene después de mostrar el 3. El uso de la instrucción nula después de la etiqueta "salida" permite compilar el código, ya que toda etiqueta debe preceder a alguna instrucción. Los usos de "goto" dentro de "switch" son variantes del uso general de "goto". "default" y "case <valor>" son etiquetas especiales en el contexto de "switch", y la etiqueta usada con "goto" debe pertenecer al mismo "switch".

## Arreglos 
Un array es una variable que es capaz de almacenar varios valores en forma simultánea. Cada uno de estos valores se identifica mediante un número que se denomina “índice”.

Para acceder al primer elemento del array se usa el índice cero, para el segundo el índice uno, para el tercero el índice dos, y así sucesivamente.

Al arreglo se lo declara de la siguiente forma:

```cs
tipo[] variable;
```
En C# los arrays son objetos derivados de la clase System.Array. Por lo tanto, y esto es muy importante, cuando declaramos un array en C# este aún no se habrá creado en la memoria de la computadora, en consecuencia, antes de poder usarlos habrá que instanciarlos, como si fuera cualquier otro objeto

```cs
tring[] nombres; // Declaración del array
nombres = new string[3]; // Instanciación del array
```
En efecto, el array nombres será utilizable únicamente a partir de su instanciación, y podrá tener un máximo de tres elementos, accedidos desde los índices 0, 1 y 2.

Nótese que índice del array comienza de CERO (0) y NO de uno (1), por lo cual el índice del último elemento es siempre el TotalDeElementos menos uno (3-1=2)

### Operaciones de recorrida de arreglos
Un array es un conjunto de objetos, ordenado y de tamaño fijo

Para acceder a cualquier elemento de este conjunto se aplica el operador postfijo `[]` sobre la tabla para indicar entre corchetes la posición que ocupa el objeto al que se desea acceder dentro del conjunto. Es decir, este operador
se usa así:
```cs
[<posiciónElemento>]
```
```cs
arrayPrueba[3] = arrayPrueba[18];
```
`Se asigna al elemento que ocupa la posición 3 en una tabla de nombre arrayPrueba, el valor del elemento que ocupa la posición 18 de dicha tabla `

### Recorrido del array
Podemos recorrer el array de la siguiente forma:
```cs
for(i=0; i < losValores.Length; i++)
{
Console.WriteLine(losValores[i]);
}
```

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Array
{
class Arreglo
    {
      static void Main(string[] args)
      {
int[] losValores = new int[4]; losValores[0] = 154; losValores[1] = 28;
losValores[2] = -1684; losValores[3] = 0;
or (int i = 0; i < losValores.Length; i++)
            {
            Console.WriteLine(losValores[i]);
            }
Console.ReadKey();
        }
    }
}
```
`CONSOLA`
- `154`
- `28`
- `-1684`
- `0`

### Recorrer el array de atras hacia adelante
```cs
for (i=losValores.Length-1; i>=0; i--)
{
    Console.WriteLine(losValores[i]);
}
```
No es necesario utilizar todos los elementos de un arreglo, por lo que, al trabajar con ellos, se puede utilizar una variable entera adicional que nos indique el número de datos que realmente estamos utilizando.

El tamaño del arreglo nos dice cuanta memoria se ha reservado para almacenar datos del mismo tipo de dato, no cuántos datos del mismo tipo tenemos realmente en el arreglo.

Ejemplo
Suma de todos los elementos de un vector:
```cs
int suma=0;
int n=losValores.Length;
for (int j=0; j < n; j++)
{
      suma= suma + losValores[j];
Console.WriteLine(suma);
```

### Búsqueda del número máximo y mínimo de un arreglo
```cs
int maximo = losValores[0], minimo = losValores[0];
// Recorremos desde la posición 1, ya que el valor de la posición 0 se asignó a maximo y a minimo
for (int a = 1; a < losValores.Length; a++)
          {
             if (losValores[a] >maximo)
             {
                    maximo = losValores[a];
             }
             if (losValores[a] <minimo)
             {
             minimo = losValores[a];
             }
          }
Console.WriteLine("El valor máximo es : " + maximo);
Console.WriteLine("El valor mínimo es : " + minimo);
```
`CONSOLA`
- `MAX: 154`
- `MIN: -1684`

### Contar cuántas veces aparece el número 10
```cs
int contador = 0;
for (int a = 0; a < osValores.Length; a++)
{
      if (losValores[a] == 10)
      {
contador++;
} }
Console.WriteLine("El numero 10 aparece: " + contador + " veces.");
```
`CONSOLA`
- `10`
- `28`
- `10`
- `-166`
- `El nro 10 aparece: 2 veces`

### Totalizar el contenido de un arreglo numérico y calcular el promedio
```cs
int suma = 0;
for (int a = 0; a < losValores.Length; a++)
{
      suma += losValores[a];
}
Console.WriteLine("La suma total es: " + suma);
Console.WriteLine("El promedio es: " + suma / losValores.Length);
```
`CONSOLA`
- `10`
- `1564`
- `128`
- `99`
- `SUMA: 1801`
- `PROMEDIO: 450`
