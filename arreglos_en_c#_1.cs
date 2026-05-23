using System;

class Program
{
    // Función recursiva para contar dígitos
    static int ContarDigitos(int n)
    {
        // Caso base
        if (n < 10)
        {
            return 1;
        }

        // Caso recursivo
        return 1 + ContarDigitos(n / 10);
    }

    static void Main()
    {
        int numero = 12543;

        int cantidad = ContarDigitos(numero);

        Console.WriteLine("El numero tiene " + cantidad + " digitos.");
    }
}

