using System;

class Program


    /*  Ejercicio #3 Partiendo del ejercicio #1 agrega un tercer numero  y modifica las
 operaciones para que cada una de ellas
 se en base a 3 y no de 2.*/

{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        double suma = numero1 + numero2 + numero3;
        double resta = numero1 - numero2 - numero3;
        double producto = numero1 * numero2 * numero3;
        double division = (numero2 != 0 && numero3 != 0) ? numero1 / numero2 / numero3 : double.NaN;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine(division != double.NaN ? $"División: {division}" : "Error: No se puede dividir por cero.");
    }
}
