using System;

class program
{
    static double[] multiplicarPorPI(int[] arreglo)
    {
        double[] resultado = new double[arreglo.Length];

        for (int i = 0; i < resultado.Length; i++)
        {
            resultado[i] = arreglo[i] * 3.14;
        }

        return resultado;
    }

    static void Main() 
    { 
        int[] numeros = { 1, 2, 3, 4, 5 };
        double[] resultado = multiplicarPorPI(numeros);
        Console.WriteLine("Arreglo multiplicado por PI:");
        
        for (int i = 0; i < resultado.Length; i++)
        { 
            Console.Write(resultado[i] + " ");
        } 
    }

}