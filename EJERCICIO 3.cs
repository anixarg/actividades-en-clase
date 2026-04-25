using System;

class Program
{
    // Funcion que calcula el area del circulo y devuelve el resultado
    public static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public static void ImprimirResultado(string texto, double resultado)
    {
        Console.WriteLine($"--- {texto} {resultado:F2} ---");
    }

    static void Main()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalcularAreaCirculo(radio);
        ImprimirResultado("EL RESULTADO ES:", area);
    }
}