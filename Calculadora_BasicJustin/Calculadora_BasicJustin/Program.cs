using System;

namespace justinCalculatorBasic

{

/*
   Ejercicio #1 de C#, Consiste en crear un programa que permita hacer las siguientes operaciones:
   Sumar, Restar, Multiplicar y Dividir. Prof.Gamalier Reyes.

    Ejercicio #2 crea un programa que permita calcular el sueldo neto de un empleado 
    partiendo del pago por hora y las horas trabajadas aplica un descuento de AFP que 
    es 2.87% y SFS que es el 3.04% suma los descuentos y luego debes restarlo del sueldo bruto.

    Ejercicio #3 Partiendo del ejercicio #1 agrega un tercer numero  y modifica las
    operaciones para que cada una de ellas
    se en base a 3 y no de 2.

    Ejercicio #4 Leee 5 numeros por teclado y calcula el promedio y luego imprime el resultado.

    Ejercicio #5 Lee la cantidad y precio de un articulo y calcula su importe
    y muestra el resultado en pantalla.

 */

}

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número entero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número entero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicacion = num1 * num2;

     
        string division = (num2 != 0) ? (num1 / (double)num2).ToString() : "No se puede dividir entre cero";



        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División: {division}");
    }
}
