namespace Punto1.clases;

public abstract class APokemon : IPokemon
{

    public int Atacar(Pokemon pokemon)
    {
        int ataque = pokemon.getAtaque();
        Random rand = new Random();
        int aleatorio = rand.Next(0, 10);
        int valor_Ataque = ataque * aleatorio;
        //Console.Write("\nvalor del ramdom = " + valor_Ataque);
        //valor_Ataque *= ataque;
        //Console.Write("\nvalor ataque antes de multiplicarlo = " + ataque);
        //Console.Write("\nvalor ataque despues de multiplicarlo = " + valor_Ataque);
        return valor_Ataque;
    }

    public int Defender(Pokemon pokemon)
    {

        Random rand = new Random();
        int valor_Defensa;
        int v_defensa = rand.Next(0, 1);
        if (v_defensa == 1)
        {
            valor_Defensa = pokemon.getDefensa();
        }
        else
        {
            valor_Defensa = (int)(pokemon.getDefensa() * 0.5);
        }




        return valor_Defensa;
    }

}