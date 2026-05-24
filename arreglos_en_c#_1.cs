using System;

class Program
{
    static int ContarDigitos(int n)
    {
        if (n < 10)
        {
            return 1;
        }

        return 1 + ContarDigitos(n / 10);
    }

    static void Main()
    {
        int numero = 12543;

        int cantidad = ContarDigitos(numero);

        Console.WriteLine("El numero tiene " + cantidad + " digitos.");
    }
}

