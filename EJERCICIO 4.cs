using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer numero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer numero:");
        int numero3 = int.Parse(Console.ReadLine());

        int resultado = ObtenerMaximo(numero1, numero2, numero3);
        Console.WriteLine($"El numero maximo es: {resultado}");
    }

    static int ObtenerMaximo(int num1, int num2, int num3)
    {
        int maximo = num1;

        if (num2 > maximo)
        {
            maximo = num2;
        }

        if (num3 > maximo)
        {
            maximo = num3;
        }

        return maximo;
    }
}
