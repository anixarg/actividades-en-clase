using System;

class Program
{
    // Método recursivo para calcular potencia
    static int CalcularPotencia(int bas, int exponente)
    {
        // Caso base
        if (exponente == 0)
        {
            return 1;
        }

        // Caso recursivo
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

            // Validación manual
            if (exponente < 0)
            {
                throw new Exception("Esta función no soporta exponentes negativos");
            }

            int resultado = CalcularPotencia(bas, exponente);

            Console.WriteLine("Resultado: " + resultado);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar números enteros.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

