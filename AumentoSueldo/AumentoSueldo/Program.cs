using System;

public class Program
{
    public static void Main()

    {
       
        Console.Write("Ingrese el sueldo del empleado: ");
        int sueldo = (int)Convert.ToDouble(Console.ReadLine());
        double aumento = sueldo * 0.15;
        double total = sueldo + aumento;

        Console.WriteLine("El suedo anterior del empleado era de:" + sueldo);
        Console.WriteLine("El empleado tuvo un aumento de:" + aumento);
        Console.WriteLine("total del aumento del empleado es:" + total);

    }
}
