using System;

class Program
{
    static int[] productoDeArreglos(int[] a, int[] b)
    {
        int N = a.Length;
        int[] c = new int[N];

        for (int i = 0; i < N; i++)
        {
            c[i] = a[i] * b[N - (i + 1)];
        }

        return c;
    }

    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] b = { 5, 6, 7, 8 };

        int[] resultado = productoDeArreglos(a, b);

        Console.WriteLine("Arreglo resultado:");

        for (int i = 0; i < resultado.Length; i++)
        {
            Console.Write(resultado[i] + " ");
        }
    }
}