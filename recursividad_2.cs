using System;

class Program
{
    static int CalcularPotencia(int bas, int exponente)
    {
        if (exponente == 0)
        {
            return 1;
        }

        return bas * CalcularPotencia(bas, exponente - 1);
    }

    static void Main()
    {
        try
        {
            Console.Write("Ingrese la base: ");
            int bas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine());

            if (exponente < 0)
            {
                throw new Exception("Esta funcion no acepta exponentes negativos");
            }

            int resultado = CalcularPotencia(bas, exponente);

            Console.WriteLine("Resultado: " + resultado);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar numeros enteros.");
        }
    }
}
