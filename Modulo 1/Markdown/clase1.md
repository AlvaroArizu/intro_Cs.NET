# Clase 1

## Que es .NET?
Es un amplio conjunto de bibliotecas de desarrollo `multilenguaje` y `multiplataforma` que esta pensado para correr sobre distintos entornos operativos, y que pretende unificar los distintos parardigmas de la programacion.

## Los 4 componentes de .NET
1. CRL (Common Language Runtime):
   
   Es el entorno de ejecucion para las app codificadas en los diferentes lenguajes que cumplen con los requisistos sintacticos y semanticos de .NET
2. MSIL (Microsoft Intermediate Leguange):
   
   Representa el codigo abierto al que es transformado el codigo fuente escrito en cualquiera de los lenguajes aceptados por .NET, luego es compilado a codigo nativo por JIT(JUST IN TIME), del CRL
3. .NET Framework:
   
   Es una colccion de clases base(plantillas), funciones para todos los propositos imaginables, que es implementada y usada por todos los lenguajes e IDE's que corren sobre .NET
4. IDE (Entorno de programacion):

   Es el ambiente de trabajo propiamente dicho conformado por herramientas de diseño, editores, depuradores y diversos asisitentes.
   
##  Implementacion de .NET
Las implementaciones de .NET incluye los siguientes componentes: 
- .NET Framework
- .NET Core
- Mono
Hay una especificacion API(Application Programming Interface), son un conjunto de librerias de codigo, comun a todas las implementaciones de .NET denominadas `.NET Standars`

  - .NET Standar: conjunto de APIs que se implementan mediante la biblioteca de clases base de una implementacion de .NET

## Areas
 - DESKTOP
   - WPF
   - Windows Forms
   - UWP
 - WEB
   - ASP .NET
 - CLOUD
   - Azure
 - MOBILE
   - Xamarrin
 - GAMING
   - Unity
 - IoT (Base de datos)
   - ARM32
   - ARM64
 - AI 
   - ML.NET
   - .NET for
   - Apache Spark
- .NET Framework
  - Windows
  - App
- .NET CORE
  - CROSS-PLATFORM
  - SERVICE
- XAMARIN
  - MOBILE
  - APP

## Diferencia entre .NET CORE y Framework
- .NET CORE
  - Es una implementacion multiplataforma de .NET diseñada para app instaldas tanto en servidores propios como servidores en la nube a gran escala
  - Puede ejecutarse en Windows, macOS, Linux
  - Implementa .NET Standard de forma que cualquier codigo que tenga como destino .NET Standard se pueda ejecutar en .NET CORE, ASP.NET
- .NET Framework 
  - Es la implementacion original de .NET de 2002, mismo entorno que se ha usado siempre en .NET
  - Contiene APIs especificas de windows 

# Que es C#?
Es un lenguaje que pretende reunir lo mejor de diversos lenguajes que compilan a nativo
- C
- C++
- Object Pascal
- ADA
  
Y de los interpretados 
- Java
- Perl
  
Estos se fusionan en uno solo y pueden correr sobre diversos sistema operativos 

C# toma gran parte de la sintaxis de C/C++ y muchas de las caracteristicas de Eiffel, ofreciendo al desarrollador un potente lenguaje 100% Orientado a objetos

# Librerias
### System
Tipos mas usados, como los tipos basicos, tablas, excepton, fechas, numeros alateorios, recolector de basura, entrada/salida en consola, etc.
### System.Collections
Collecciones de datos de uso comun como pilas, colas, listas, diccionarios, etc
### System.Data
Manipulacion de base de datos. Formando la arquitectura ADO.NET
### System.IO
Manipulacion de archivos y otros flujos de datos
### System.Net
Realizacion de comunicaciones en red
### System.Reflection
Acceso a los metadatos que acompañan a los modulos de codigo
### System.Security
Acceso a la politica de seguridad en que se basa el CRL
### System.Runtime.Remoting
Acceso a objetos remotos
### System.Threading
Manipulacion de hilos de ejecucion
### System.Wen.UI.WebControls
Creacion de interface de usuario basada en ventanas para la app web
### System.Windows.Forms
Creacion de interfaces de usuarios nasadas en ventanas para app estandar

# Variables
Tienen tipos de dato: 
### Enteros 
- int,
- byte, - 1byte
- sbyte (-128,127) - 1byte
- ushort - 2byte
- uitn - 4byte
- unlong - 8byte
### Reales
- float (23.99999999f) precision de 7 diagitos - 4 bytes
- double, es de doble precision de 15 digitos - 8 bytes
- decimal, precision de 28 digitos - 16 bytes

### Caracteres
- char, 1 caracter
- string, cadena de caracteres


### Logicos 
- bool, true o false

### Constantes
- const `tipo de variables` NOMBRE = N;

## Operdores logicos
- AND &
- OR ||
- XOR ^
- NOT !

### Impresion en pantalla de un valor dentro de un string
```cs
byte x=10, y=5;
Console.WriteLine("El valor de x es {0} valor de y {1}",x, y);
```
### Console.WriteLine(); Para mostrar por consola con salto de linea
### Console.Write(); Para mostrar por consila sin salto de linea
### Console.ReadKey(); Para cerrar el ejecutable 
### Console.ReadLine(); Para que el usuario ingrese por consola datos












