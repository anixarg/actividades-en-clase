using System;

class program
{
    static int[] reverso(int[] arrgeglo)
    {
        int N = arrgeglo.Length;
        int[] invertido = new int[N];
        for (int i = 0; i < N; i++)
        {
            invertido[i] = arrgeglo[N - 1 - i];
        }
        return invertido;
    }

    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        int[] resultado = reverso(numeros);
        Console.WriteLine("Arreglo invertido: ");

        for (int i = 0; i < resultado.Length; i++)
        {
            Console.Write(resultado[i] + " ");
        }
    }

}



