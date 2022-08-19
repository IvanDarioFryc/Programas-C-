internal class Jugador
{
    public string nombre;
    public int puntuacion;
    public int partidasPerdidas;

    public Jugador(string nombre, int puntuacion, int partidasPerdidas)
    {
        this.nombre = nombre;
        this.puntuacion = puntuacion;
        this.partidasPerdidas = partidasPerdidas;

    }

    public override string ToString()
    {
        return  nombre + "  " + puntuacion + "  " + partidasPerdidas  ;
    }
}