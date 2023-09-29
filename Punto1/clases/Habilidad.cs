namespace Punto1.clases;

public class Habilidad
{
    private string nombre { get; set;}
    private int puntaje { get; set;}

    private string tipo { get; set;}
    public Habilidad(string nombre, int puntaje, string tipo)
    {
        this.nombre = nombre;
        this.puntaje = puntaje;
        this.tipo = tipo;

    }
}
