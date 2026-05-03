using System;

class Program
{
    // funcionamiento para retirar
    public static double RealizarRetiro(double saldo, double retiro)
    {
        if (retiro > saldo)
        {
            Console.WriteLine("Error: El monto a retirar excede el saldo actual.");
            return saldo;
        }
        else
        {
            return saldo - retiro;
        }
    }

    static void Main()
    {
        double saldoActual = 1000; // saldo inicial
        Console.WriteLine("Saldo inicial: " + saldoActual);

        Console.Write("Ingrese el monto a retirar: ");
        double montoARetirar = Convert.ToDouble(Console.ReadLine());

        saldoActual = RealizarRetiro(saldoActual, montoARetirar);
        Console.WriteLine("Saldo restante: " + saldoActual);
    }
}