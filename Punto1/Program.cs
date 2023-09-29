// See https://aka.ms/new-console-template for more information



using Punto1.clases;

Console.WriteLine("Pokemon!");


/*
Console.WriteLine($"nombre del pokemon es {p1.getNombre()}");
 */

List<Pokemon> lista_Pokemones = new List<Pokemon>();

int[] ataques1 = { 5, 6, 2 };
Pokemon p1 = new Pokemon("Bulbasaur.", "A", 5, ataques1);

int[] ataques2 = { 6, 2, 1 };
Pokemon p2 = new Pokemon("Charmander.", "B", 5, ataques2);

lista_Pokemones.Add(p1);
lista_Pokemones.Add(p2);


int opc;
Console.Clear();

do
{
    Console.WriteLine("Seleccione\n 1. Para crear Pokemon\n 2. Para Iniciar Pelea\n 3. Salir\n ");
    opc = Int32.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:

            if (lista_Pokemones.Count() == 2)
            {
                Console.WriteLine("Solo se pueden crear 2 Pokemones por pelea");
                break;
            }

            string nombre;
            string tipo;
            int defensa;
            int[] ataques = new int[3];
            Console.WriteLine("Ingrese Nombre Pokemon:\n");
            tipo = Console.ReadLine();

            Console.WriteLine("Ingrese tipo de Pokemon:\n");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Valor de la defensa del Pokemon:\n");
            defensa = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < ataques.Length; i++)
            {
                Console.WriteLine("Ingrese el valor del ataque N:" + i);
                ataques[i] = Int32.Parse(Console.ReadLine());
            }

            Pokemon pokemon_New = new Pokemon(nombre, tipo, defensa, ataques);

            lista_Pokemones.Add(pokemon_New);
            /* else
            {
                Console.WriteLine("Solo se pueden crear 2 Pokemones por pelea");
            } */


            Console.WriteLine("El pokemon creado es:");
            Console.WriteLine(pokemon_New.getNombre());


            Console.WriteLine("se creo el pokemon!");
            break;

        case 2:
            int turnos_Ganados_Pokemon1 = 0;
            int turnos_Ganados_Pokemon2 = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Aqui crea los pone a pelear!");
                int valorAtaqueP1 = lista_Pokemones[0].Atacar(lista_Pokemones[0]);
                int valorDefensaP1 = lista_Pokemones[0].Defender(lista_Pokemones[0]);
                int valorAtaqueP2 = lista_Pokemones[1].Atacar(lista_Pokemones[1]);
                int valorDefensaP2 = lista_Pokemones[1].Defender(lista_Pokemones[1]);

                if (valorAtaqueP1 > valorDefensaP2)
                {
                    Console.WriteLine(valorAtaqueP1);
                    Console.WriteLine(valorDefensaP2);
                    turnos_Ganados_Pokemon1 += 1;
                    //Console.WriteLine("Gano Pokemon1");
                }

                if (valorAtaqueP2 > valorDefensaP1)
                {
                    Console.WriteLine(valorAtaqueP1);
                    Console.WriteLine(valorDefensaP2);
                    turnos_Ganados_Pokemon2 += 1;
                    //Console.WriteLine("Gano Pokemon2");
                }

                /*                Console.WriteLine(valorAtaqueP1);
                               Console.WriteLine(valorDefensaP1);
                               Console.WriteLine(valorAtaqueP2);
                               Console.WriteLine(valorDefensaP2); */
            }
            Console.WriteLine("Puntos Pokemon1: " + turnos_Ganados_Pokemon1);
            Console.WriteLine("Puntos Pokemon2: " + turnos_Ganados_Pokemon2);
            if (turnos_Ganados_Pokemon1 > turnos_Ganados_Pokemon2)
            {
                Console.WriteLine("Gano Pokemon 1: " + lista_Pokemones[0].getNombre());
                break;
            }

            if (turnos_Ganados_Pokemon1 < turnos_Ganados_Pokemon2)
            {
                Console.WriteLine("Gano Pokemon 2: " + lista_Pokemones[1].getNombre());
                break;
            }

            if (turnos_Ganados_Pokemon1 == turnos_Ganados_Pokemon2)
            {
                Console.WriteLine("Empetaron");
                break;
            }



            break;

        default:
            Console.WriteLine("Opcion Invalida ");
            break;
    }


} while (opc != 3);