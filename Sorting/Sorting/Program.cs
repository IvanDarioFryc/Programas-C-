using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Example
{
    public static void Main()
    {
        //Metodos
        void ordenarPorPuntuacionYNombre(List<Jugador> lista)
        {
            lista.Sort(delegate (Jugador x, Jugador y)
            {

                if (x.puntuacion == y.puntuacion)
                {
                    return x.nombre.CompareTo(y.nombre);
                }
                else
                {
                    return y.puntuacion.CompareTo(x.puntuacion);
                }


            });

            Console.WriteLine(String.Join(Environment.NewLine, lista));
        }
        void ordenarPorPuntuacionPerdidasYNombre(List<Jugador> lista)
        {
            lista.Sort(delegate (Jugador x, Jugador y)
            {

                if (x.puntuacion == y.puntuacion)
                {
                    if (x.partidasPerdidas==y.partidasPerdidas)
                    {
                        return x.nombre.CompareTo(y.nombre);
                    }
                    else
                    {
                        return x.partidasPerdidas.CompareTo(y.partidasPerdidas);
                    }
                }
                else
                {
                    return y.puntuacion.CompareTo(x.puntuacion);
                }


            });

            Console.WriteLine(String.Join(Environment.NewLine, lista));
        }

        //declaramos los constructores
        Jugador jug1 = new Jugador("Ivan", 10000, 10);
        Jugador jug2 = new Jugador("Federico", 8000, 15);
        Jugador jug3 = new Jugador("Sebastian", 8000, 15);
        Jugador jug4 = new Jugador("Lucas", 6000, 20);
        Jugador jug5 = new Jugador("Martin", 6000, 21);
        Jugador jug6 = new Jugador("Alejandro", 6000, 23);
        Jugador jug7 = new Jugador("Damian", 8000, 16);


        //declaramos la lista
        List<Jugador> ListaJugadores = new List<Jugador>() { jug1, jug2, jug3, jug4, jug5, jug6, jug7 };

        //aplicamos los metodos para que nos devuelvan las listas ordenadas.

        //El orden se rige por los puntos y la primer letra del nombre. La cantidad de partidas perdidas no influye.
        Console.WriteLine("Lista ordenada por puntos de manera descendente y por orden alfabetico ascendente:\n");
        Console.WriteLine("\nNombre   Puntos  Partidas Perdidas\n");
        ordenarPorPuntuacionYNombre(ListaJugadores);

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        //El orden se rige primero por los puntos, luego por la cantidad de partidas perdidas, y despues po la primer letra del nombre. 
        Console.WriteLine("Lista ordenada por puntos y partidas perdidas de manera descendente y por orden alfabetico ascendente:\n");
        Console.WriteLine("\nNombre   Puntos  Partidas Perdidas\n");
        ordenarPorPuntuacionPerdidasYNombre(ListaJugadores);


        Console.ReadKey();
    }
}