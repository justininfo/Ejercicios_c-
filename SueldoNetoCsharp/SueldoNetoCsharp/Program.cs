using System;

namespace SueldoEmpleado;

class Program

/*  Ejercicio #2 crea un programa que permita calcular el sueldo neto de un empleado 
partiendo del pago por hora y las horas trabajadas aplica un descuento de AFP que
es 2.87% y SFS que es el 3.04% suma los descuentos y luego debes restarlo del sueldo bruto.
*/

{
    static void Main()
    {
        Console.Write("Ingrese el pago por hora: ");
        double pagoPorHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese las horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        (double sueldoBruto, double totalDescuentos, double sueldoNeto) = CalcularSueldoNeto(pagoPorHora, horasTrabajadas);

        Console.WriteLine($"Sueldo Bruto: {sueldoBruto:F2}");
        Console.WriteLine($"Total Descuentos: {totalDescuentos:F2}");
        Console.WriteLine($"Sueldo Neto: {sueldoNeto:F2}");
    }
     static (double, double, double) CalcularSueldoNeto(double pagoPorHora, double horasTrabajadas)
    {
        double sueldoBruto = pagoPorHora * horasTrabajadas;

        double descuentoAfp = sueldoBruto * 0.0287; 
        double descuentoSfs = sueldoBruto * 0.0304; 

        double totalDescuentos = descuentoAfp + descuentoSfs;

        double sueldoNeto = sueldoBruto - totalDescuentos;

        return (sueldoBruto, totalDescuentos, sueldoNeto);
    }
}


