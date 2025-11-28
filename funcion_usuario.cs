
using System;

class Program
{
    // Función para calcular el promedio de tres números
    static double CalcularPromedio(double num1, double num2, double num3)
    {
        double promedio = (num1 + num2 + num3) / 3;
        return promedio;
    }

    static void Main()
    {
        Console.WriteLine("Calcula el promedio de tres números");

        Console.Write("Ingrese el primer número: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double resultado = CalcularPromedio(a, b, c);
        Console.WriteLine($"El promedio es: {resultado}");
    }
}
