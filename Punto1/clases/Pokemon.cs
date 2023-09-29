namespace Punto1.clases;

public class Pokemon : APokemon
{


    //private Habilidad defensa { get; set; }
    //private Habilidad[] ataque = new Habilidad[3];
    private string nombre { get; set; }
    private string tipo { get; set; }
    private int[] ataque /* = new int[3] */ { get; set; }
    private int defensa { get; set; }

    public Pokemon(string nombre,string tipo, int defensa, int[] ataque)
    {
        this.nombre = nombre;
        this.tipo = tipo;
        this.defensa = defensa;
        this.ataque = ataque;
    }

    public int getAtaque()
    {
        Random rand = new Random();
        int ataque_Seleccionado = rand.Next(0, this.ataque.Length);
        int valor_Ataque = this.ataque[ataque_Seleccionado];
        return valor_Ataque;
    }

    public int getDefensa()
    {
        return this.defensa ;
    }

       public string getNombre()
    {
        return this.nombre ;
    }

}