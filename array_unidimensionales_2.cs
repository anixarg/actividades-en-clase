using System;

class Program
{
    static int busquedaL(int[] arreglo, int numero)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == numero)
            {
                return i; // devuelve la posicioon
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] datos = { 5, 3, 1, 2, 4 };

        Console.Write("Ingrese el numero que quiere encontrar en el arreglo: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = busquedaL(datos, numero);

        if (resultado != -1)
        {
            Console.WriteLine("Numero encontrado en la posicion: " + resultado);
        }
        else
        {
            Console.WriteLine("El numero no se encuentra en el arreglooo");
        }
    }
}

