/*int edad= 29;

Console.WriteLine("Hello, Gerardito Vollmer! tengo {0} años", edad);*/


/*
//clase system.random para generar numeros aleatorios
// 1. Instanciar (una vez)
        Random rnd = new Random();

        // 2. Llamar a métodos
        int num1 = rnd.Next();          // Entero aleatorio positivo
        int num2 = rnd.Next(1, 11);     // Número entre 1 y 10
        double num3 = rnd.NextDouble(); // Número entre 0.0 y 1.0

        Console.WriteLine($"Aleatorio: {num1}");
        Console.WriteLine($"Entre 1 y 10: {num2}");
        Console.WriteLine($"Double: {num3}"); 
*/


// Ejercicio 1: Incorporación de una instrucción if para mostrar diferentes mensajes según el valor de la variable total
// Ejercicio 2: Incorporación de otra instrucción if para implementar puntos extra por obtener dobles
//              "Si dos dados cualesquiera muestran el mismo valor, se obtendrán dos puntos extra por obtener dobles"
// Ejercicio 3: Creación de una lógica de decisión anidada con if, else if y else
/*Random numAl = new Random(); // Instancia de la clase Random para generar números aleatorios

int num1 = numAl.Next(6); // Número entre 0 y 5 (inclusive)
int num2 = numAl.Next(6); 
int num3 = numAl.Next(5); 

num1 = 6;
num2 = 6;
num3 = 6;

int sumTotal = num1 + num2 + num3;

Console.WriteLine($"Numero 1: {num1} + \nNumero 2: {num2} + \nNumero 3: {num3} = \nTotal: {sumTotal}");

if ((num1 == num2) || (num1 == num3) || (num2 == num3)) //denomina condición compuesta
{
    if ((num1 == num2) && (num2 == num3))
    {
        Console.WriteLine("¡Triple acierto! Has ganado +6 puntos extra.");
        sumTotal += 6;
    }
    else
    {
        Console.WriteLine("¡Doble acierto! Has ganado +2 puntos extra.");
         sumTotal += 2;
    }

    Console.WriteLine($"Your total including the bonus extra points is: {sumTotal}");
}
//---------------------------------------------------------------------
if (sumTotal >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (sumTotal >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (sumTotal == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten(gatito)!");
}

*/

//Ejercicio: Realización de una actividad 
//de desafío para aplicar reglas de negocio



/*// 1- “Pedir un número y mostrar su doble”
Console.WriteLine("Ingrese un numero"); //Pido el número al usuario
int num = int.Parse(Console.ReadLine()); //Convierto el numero ingresado a entero

Console.WriteLine($"el doble es: {num * 2}"); //muestro el resultado doble en pantalla aplicando $ para interpolación de cadenas..*/

/*// 2- Pedir 2 numeros y mostrar su suma
int num = 0, sum = 0, Total=0;

Console.WriteLine("Ingrese su primer numero para sumar: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su segundo numero para sumar: ");
sum = int.Parse(Console.ReadLine());

Total = num + sum;
Console.WriteLine($"Total es: {Total}"); */

// 3- Pedir un numero y decir si es par o impar
/*int num=0;
Console.WriteLine("ingerese un numero, y adivino si es par o impar: ");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"El numero {num} es par");
}
else
{
    Console.WriteLine($"El numero {num} es impar");
}*/

//4-Pedir edad y decir si es mayor de edad

/*int edad = 0;

Console.WriteLine("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Estas autorizado");
}
else if (edad < 18)
{
    Console.WriteLine("Denegado, espera a ser mayor");
} */
// Calcular el promedio de N numeros.
/*Console.Write("¿Cuántos números desea ingresar?: ");
int cantidad = int.Parse(Console.ReadLine());

int suma = 0;

for (int i = 1; i <= cantidad; i++)
{
    Console.Write("Ingrese número: ");
    int numero = int.Parse(Console.ReadLine());

    suma = suma + numero;
}

double promedio = (double)suma / cantidad;

Console.WriteLine("El promedio es: " + promedio);*/

/*int positivos = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingrese número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        positivos++;
    }
}

Console.WriteLine("Positivos: " + positivos);

*/

int edad = 0;
int contador = 0;
int acumulador = 0;
float promedio = 0;

do
{
    Console.Write("Ingrese las edades: ");
    edad = int.Parse(Console.ReadLine());

    contador++;
    acumulador = acumulador + edad;

}while(edad!=0);

promedio = acumulador / contador;
Console.WriteLine($"El promedio de alumno es: {promedio} ");

