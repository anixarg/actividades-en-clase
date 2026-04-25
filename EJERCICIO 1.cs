using System;

class Program
{
    static void Main(string[] args)
    {
        // EL USUARIO INGRESA SU EDAD
        Console.Write("Ingrese la edad: ");
        int edad;
        bool esNumero = int.TryParse(Console.ReadLine(), out edad);

        // VALIDACION DEL NUMERO
        if (!esNumero)
        {
            Console.WriteLine("Por favor, ingrese un número válido para la edad.");
        }
        else
        {
            bool esMayor = EsMayorDeEdad(edad);
            if (esMayor)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("No es mayor de edad.");
            }
        }
    }

    // VERIFICACION DE QUE SI ES MAYOR
    public static bool EsMayorDeEdad(int edad)
    {
        return edad >= 18;
    }
}
