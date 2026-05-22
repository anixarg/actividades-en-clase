//Ejercicio 1: Escribir una función/método llamado mezclarArreglos que toma 2 arreglos de enteros del
//mismo tamaño y devuelve un nuevo arreglo del mismo tamaño que el de los de entrada que
//contiene los elementos de posiciones impares del primer arreglo y los de posiciones pares delsegundo arreglo.

using System;

class Program
{
    static int[] mezclarArreglos(int[] arreglo1, int[] arreglo2)
    {
        int[] resultado = new int[arreglo1.Length];

        for (int i = 0; i < arreglo1.Length; i++)
        {
            if (i % 2 == 0) // posición par
            {
                resultado[i] = arreglo2[i];
            }
            else // posición impar
            {
                resultado[i] = arreglo1[i];
            }
        }

        return resultado;
    }

    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        int[] b = { 10, 20, 30, 40, 50 };

        int[] mezcla = mezclarArreglos(a, b);

        Console.WriteLine("Arreglo mezclado:");

        for (int i = 0; i < mezcla.Length; i++)
        {
            Console.Write(mezcla[i] + " ");
        }
    }
}

