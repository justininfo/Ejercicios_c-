using System;

public class Program

/*  Ejercicio #6 Crear un programa que calcule la cantidad y precio de un articulo, luego 
calcular impuestos de ITBIS del 18%, aplicar un descuento del 10%, y 
calcular el total genearal. El ITBIS se calcula multiplicando el importe 
por el 18%, el descuento se calcula multiplicando el importe por el 10-% y 
el total general se calcula restando el importe menos 
descuento mas ITBIS.
*/

{
    public static void Main()
    {
        Console.Write("Ingrese la cantidad del artículo: ");
        int cantidad = (int)Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el precio del artículo: ");
        double precio = (int)Convert.ToDouble(Console.ReadLine());

        double importe =  cantidad * precio;
        double impuesto = importe * 0.18;
        double descuento = importe * 0.10;
        double total = importe - impuesto - descuento;

        Console.WriteLine("El importe es:" + importe);
        Console.WriteLine("ITBIS:" + impuesto);
        Console.WriteLine("Descuento:" + descuento);
        Console.WriteLine("Total:" + total);








    }
}
