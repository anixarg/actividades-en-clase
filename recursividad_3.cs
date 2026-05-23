using System;

class Program
{
    static void InvertirNumero(int n)
    {
        if (n < 10)
        {
            Console.Write(n);
            return;
        }

        Console.Write(n % 10);

        InvertirNumero(n / 10);
    }

    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Numero invertido: ");

        InvertirNumero(numero);
    }
}

