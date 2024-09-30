using System;

class Program

    /*  Ejercicio #5 Lee la cantidad y precio de un articulo y calcula su importe
 y muestra el resultado en pantalla.*/

{
    static void Main()
    {
        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el precio: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El importe total es: {cantidad * precio}");
    }
}
