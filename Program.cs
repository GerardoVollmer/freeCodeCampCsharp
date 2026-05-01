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
//Ejeercicio 2: Incorporación de otra instrucción if para implementar puntos extra por obtener dobles
//              "Si dos dados cualesquiera muestran el mismo valor, se obtendrán dos puntos extra por obtener dobles"
Random numAl = new Random(); // Instancia de la clase Random para generar números aleatorios

int num1 = numAl.Next(1, 7); // Número entre 1 y 6 (inclusive)
int num2 = numAl.Next(1, 7); 
int num3 = numAl.Next(1, 7); 

int sumTotal = num1 + num2 + num3;

Console.WriteLine($"Numero 1: {num1} + \nNumero 2: {num2} + \nNumero 3: {num3} = \nTotal: {sumTotal}");

if ((num1 == num2) || (num1 == num3) || (num2 == num3)) //denomina condición compuesta
{
    Console.WriteLine("¡Doble! Has ganado +2 puntos extra.");
    sumTotal += 2;
}
if ((num1 == num2) && (num2 == num3))
{
    Console.WriteLine("¡Triple! Has ganado +6 puntos extra.");
    sumTotal += 6;
}
//---------------------------------------------------------------------
if (sumTotal >= 15)
{
    Console.WriteLine("Haz ganado el primer premio");
}
if (sumTotal < 15)
{
    Console.WriteLine("Sorry, You lose.");
}


/*
// Expresion booleana con string.Contains(), evalua si una cadena contiene otra
string message = "the quick brown fox jump over the lazy dog.";
bool result = message.Contains("fox");

Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
*/