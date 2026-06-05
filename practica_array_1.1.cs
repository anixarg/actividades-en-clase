using System;

class program
{
    static void Main()
    {
        int[] numeros = { 5, 12, 8, 3, 7, 10, 15, 6, 9, 4 };

        int suma = 0;

        foreach (int num in numeros)
        {
            suma += num;
        }

        double promedio = (double)suma / numeros.Length;

        Console.WriteLine($"suma : {suma}");
        Console.WriteLine($"promedio : {promedio}");

    }
}


