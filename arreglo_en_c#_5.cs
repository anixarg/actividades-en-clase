using System;

class Program
{ 
    static int busquedaLineal(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valor)
            {
                return i; // devuelve la posicioon
            }
        }

        return -1; // indica que no se encontro la posicioon
    }

    static void Main()
    {
        int[] numeros = { 4, 8, 15, 16, 23, 42 };

        Console.Write("Ingrese el numero que quiere encontrar en el arreglo: ");
        int valor = int.Parse(Console.ReadLine());

        int posicion = busquedaLineal(numeros, valor);

        if (posicion != -1)
        {
            Console.WriteLine("Numero encontrado en la posicion: " + posicion);
        }
        else
        {
            Console.WriteLine("El numero no se encuentra en el arreglooo");
        }
    }
}


