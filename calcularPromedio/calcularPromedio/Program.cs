using System;

class Program

    /*  Ejercicio #4 Leee 5 numeros por teclado 
     y calcula el promedio y luego imprime el resultado.*/

{
    static void Main()
    {
        double num1, num2, num3, num4, num5, suma;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el cuarto número: ");
        num4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el quinto número: ");
        num5 = Convert.ToDouble(Console.ReadLine());

        suma = num1 + num2 + num3 + num4 + num5;

        double promedio = suma / 5;
        Console.WriteLine($"El promedio es: {promedio}");
    }
}
