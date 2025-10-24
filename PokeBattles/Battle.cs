using System;

public class Battle
{
    // egenskaper
    string name;
    Pokemon pokemon1;
    Pokemon pokemon2;

    // konstruktor
    public Battle(string name, Pokemon pokemon1, Pokemon pokemon2)
    {
        this.name = name;
        this.pokemon1 = pokemon1;
        this.pokemon2 = pokemon2;
    }

    public Pokemon Start()
    {
        Pokemon winner = null;

        Console.WriteLine(); 
        Console.WriteLine("Battle " + name + " startar mellan " + pokemon1.Name + " och " + pokemon2.Name);
        Console.WriteLine();
        pokemon1.PrintInfo();
        pokemon1.PrintInfo();
        Console.WriteLine();
        // fight until one pokemon's health is 0 or less

        while (pokemon1.health > 0 && pokemon2.health > 0)
        {
            // pok2 slår pok1
            Console.WriteLine(pokemon2.Name + " slår " + pokemon1.Name + " med " + pokemon2.damage);
            pokemon1.health = pokemon1.health - pokemon2.damage;
            Console.WriteLine(pokemon1.Name + " har " + pokemon1.health + " kvar ");

            // pok1 slår pok2
            Console.WriteLine(pokemon1.Name + " slår " + pokemon2.Name + " med " + pokemon1.damage);
            pokemon2.health = pokemon2.health - pokemon1.damage;
            Console.WriteLine(pokemon2.Name + " har " + pokemon2.health + " kvar ");

            if(pokemon1.health <= 0)
            {
                winner = pokemon2;
            }
            else if(pokemon2.health <= 0)
            {
                winner = pokemon1;
            }
        }
        if (winner != null)
        {
            //Console.WriteLine("Vinnaren är " + winner.Name);
        }
        return winner;
    }
}
