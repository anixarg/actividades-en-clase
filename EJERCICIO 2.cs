using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != 3)
        {
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Salir");
            Console.Write("Elija una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese los grados Celsius: ");

                string textoCelsius = Console.ReadLine();
                double celsius = double.Parse(textoCelsius);

                double fahrenheit = CelsiusAFahrenheit(celsius);

                Console.WriteLine(celsius + "°C son " + fahrenheit + "°F");
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese losgrados Fahrenheit: ");

                string textoFahrenheit = Console.ReadLine();
                double fahrenheit = double.Parse(textoFahrenheit);

                double celsius = FahrenheitACelsius(fahrenheit);

                Console.WriteLine(fahrenheit + "°F son " + celsius + "°C");
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Programa se ha finalizadoooo");
            }
            else
            {
                Console.WriteLine("Opcion invalida.");
            }

            Console.WriteLine();
        }
    }

    static double CelsiusAFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    static double FahrenheitACelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}