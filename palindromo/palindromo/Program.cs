using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Example
{
    public static void esPalindromo(int flag)
    {
        if(flag== 0)
        {
            Console.WriteLine("\n\nla cadena es palindromo");
        }
        else
        {
            Console.WriteLine("\n\nLa cadena NO es palindromo");
        }
    }

    public static void esUnaFrase(string[] NuevoArray)
    {
        
        Console.WriteLine("\n\nCadena acomodada:");

        for (int i = 0; i < NuevoArray.Length; i++)
        {
            Console.Write(NuevoArray[i]);
        }
    }
    public static void Main()
    {
        Console.WriteLine("Descubra si la cadena es palindromo!!!\n");
        Console.WriteLine("ingrese una cadena:");
        string cadena = Console.ReadLine();

        string[] array = new string[cadena.Length];
       
        

        for (int i = 0; i < array.Length; i++)
        {
            if(cadena.Substring(i, 1)!="")
            {
                array[i] = cadena.Substring(i, 1);
            }
        }

        //Contamos los espacios vacios para saber si se trata de una frase o una cadena

        int contadorDeEspaciosVacios = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==" ")
            {
                contadorDeEspaciosVacios++;
                
            }
        }

        string[] NuevoArraySinEspacios = new string[array.Length - contadorDeEspaciosVacios];

        
        string[] ArrayDadoVuelta = new string[array.Length- contadorDeEspaciosVacios];
        int j = ArrayDadoVuelta.Length - 1;

        for (int i = 0; i < NuevoArraySinEspacios.Length; i++)
        {
            if (array[i] != " ")
            {
            
                NuevoArraySinEspacios[i] = array[i];

            }
        }

        //contadores que iran subiendo depende el array al cual estan relacionados
        int l = 0;
        int L = 0;

        //pasamos del array con espacios a un array sin espacios para trabajar mejor

        while(l<NuevoArraySinEspacios.Length)
        {
            if (array[L] != " ")
            {

                NuevoArraySinEspacios[l] = array[L];
                l++;
                L++;
            }
            else
            {
                L++;
            }
           
        }

        if (contadorDeEspaciosVacios>0)
        {
            esUnaFrase(NuevoArraySinEspacios);
        }
       
        //finalmente pasamos a un nuevo array la cadena a la inversa
        for (int i = 0; i < ArrayDadoVuelta.Length; i++)
        {
            
                ArrayDadoVuelta[j] = NuevoArraySinEspacios[i];
                j--;
        }
        j = 0;
        

        Console.WriteLine("\n\nCadena dada vuelta:");

        for (int i = 0; i < ArrayDadoVuelta.Length; i++)
        {
            Console.Write(ArrayDadoVuelta[i]);
        }

        //verificamos si es palindromo

        int flag = 0;
        for (int i = 0; i < ArrayDadoVuelta.Length; i++)
        {
            if (NuevoArraySinEspacios[i] != ArrayDadoVuelta[i])
            {
                flag = 1;
            }
        }
        esPalindromo(flag);

        Console.ReadKey();
    }
}
