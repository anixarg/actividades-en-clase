using System;

class Program
{
    // Formula que convierte Celsius a Fahrenheit
    public static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9.0 / 5.0) + 32;
    }

    // Formula que convierte Fahrenheit a Celsius
    public static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5.0 / 9.0;
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("Conversor de Temperaturas");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese grados Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = CelsiusAFahrenheit(celsius);
                    Console.WriteLine($"{celsius}°C son {fahrenheit:F2}°F");
                    break;
                case 2:
                    Console.Write("Ingrese grados Fahrenheit: ");
                    double f = double.Parse(Console.ReadLine());
                    double c = FahrenheitACelsius(f);
                    Console.WriteLine($"{f}°F son {c:F2}°C");
                    break;
                case 3:
                    Console.WriteLine("El proceso ha sido terminando");
                    break;
                default:
                    Console.WriteLine("Opción inválida, ingrese una de las opciones de las que estan ahi...");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 3);
    }
}