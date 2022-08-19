using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Example
{
    public static void Main()
    {
        Console.WriteLine("Ingrese una cadena de caracteres:\n");
        //string cadenaInicial = "aabbccc";

        //se declara la cadena ingresada por consola
        string cadenaInicial = Console.ReadLine();
        Console.WriteLine("\nLa cadena inicial es: " + cadenaInicial + "\n");

        //metemos la cadenadentro de un array para que se pueda trabajar mejor

        string[] arrayCadena = new string[cadenaInicial.Length];

        string[] almacenDeCaracteresUsados = new string[cadenaInicial.Length];

        string[] letras = new string[cadenaInicial.Length];

        int[] contadoresDeLetras = new int[cadenaInicial.Length];

        string letraInicial = "";

        int contadorDeLetras = 0;

        //Tomo la primer letra de la cadena
        for (int i = 0; i < arrayCadena.Length; i++)
        {
            arrayCadena[i] = cadenaInicial.Substring(i, 1);

        }

        for (int i = 0; i < cadenaInicial.Length; i++)
        {

            if (arrayCadena[i] != letraInicial)
            {
                letras[contadorDeLetras] = arrayCadena[i];
                letraInicial = arrayCadena[i];
                contadorDeLetras++;
            }
        }

        

        //contar las repeticiones de cada letra

       

        for (int i = 0; i < letras.Length; i++)
        {
            int cont = 0;
            for (int j = 0; j < arrayCadena.Length; j++)
            {


                if (arrayCadena[j] == letras[i])
                {
                    cont++;
                }

            }

            contadoresDeLetras[i] = cont;
        }


        //construimos la funciuon que determina si hay caracteres que se repiten distinto numero de veces que otros 
        Boolean HayDiferencia(int[] arrayDeContadores)
        {
            for (int i = 0; i < arrayDeContadores.Length; i++)
            {
                if (arrayDeContadores[i]==0)
                {
                    arrayDeContadores[i] = arrayDeContadores[i - 1];
                }
            }
            int flag=0;
            for (int i = 0; i < arrayDeContadores.Length; i++)
            {

                flag = 0;
                for (int j = 0; j < i; j++)
                {
                    
                    if (arrayDeContadores[i] != arrayDeContadores[j] && arrayDeContadores[j]!=0)
                    {
                        j = i;
                        flag = 1;
                    }
                }
                

            }
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Limpiar los arrays

        int contadorDeLetrasPreciso = 0;
        for (int i = 0; i < letras.Length; i++)
        {
            if (letras[i] != "")
            {
                contadorDeLetrasPreciso++;
            }
        }
        string[] letrasPreciso = new string[contadorDeLetrasPreciso];

        for (int i = 0; i < letrasPreciso.Length; i++)
        {
            letrasPreciso[i] = letras[i];
        }

        int contadorDeContadoresPreciso = 0;
        for (int i = 0; i < contadoresDeLetras.Length; i++)
        {
            if (contadoresDeLetras[i] != 0)
            {
                contadorDeContadoresPreciso++;
            }
        }
        int[] contadoresDeLetrasPreciso = new int[contadorDeContadoresPreciso];

        for (int i = 0; i < contadoresDeLetrasPreciso.Length; i++)
        {
            contadoresDeLetrasPreciso[i] = contadoresDeLetras[i];
        }
        
        Console.WriteLine("letras y sus contadores:\n");

        for (int i = 0; i < contadoresDeLetrasPreciso.Length; i++)
        {
            int flag = 0;
            
            for (int j = 0; j < i; j++)
            {
                if (letrasPreciso[i] == letrasPreciso[j])
                {
                    j = i;
                    flag = 1;
                }
            }
            if (flag == 0) 
            {
                Console.WriteLine("la letra '" + letrasPreciso[i] + "' aparece " + contadoresDeLetrasPreciso[i] + " veces\n");
            }

        }

        //Se aplica el metodo que calcula si hay caracteres que se repiten distinto numero de veces que otros
        if (HayDiferencia(contadoresDeLetras)==true)
        {
            Console.WriteLine("\nLos caracteres de la cadena se repiten en un numero desigual de veces.");
        }
        else if (HayDiferencia(contadoresDeLetras) == false)
        {
            Console.WriteLine("\nLos caracteres de la cadena se repiten en un numero uniforme de veces.");
        }

        Console.ReadKey();
    }
}