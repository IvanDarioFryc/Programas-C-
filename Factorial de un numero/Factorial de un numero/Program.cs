using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Example
{
    private static int calcularFactorial(int numero)
    {
        int factorial = 1;
        for (int i = numero; i > 0; i--)
        {
            factorial=factorial*i;
        }

        return factorial;
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese un numero: ");
        string num = Console.ReadLine();
        int numero = Int16.Parse(num);

        Console.WriteLine("\nEl factorial de " + numero + " es:");
        Console.WriteLine(calcularFactorial(numero));

        Console.ReadKey();
    }
}
