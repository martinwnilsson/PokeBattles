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
        Console.WriteLine("Battle " + name + " startar mellan " + pokemon1.name + " och " + pokemon2.name);
        Console.WriteLine("---");
        Console.WriteLine("Stats:");
        pokemon1.PrintInfo();
        pokemon2.PrintInfo();
        Console.WriteLine("---");
        Console.WriteLine("Fight!");
        // fight until one pokemon's health is 0 or less

        while (pokemon1.health > 0 && pokemon2.health > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Tryck på en tangent för nästa runda...");
            Console.ReadLine();
            // pok2 slår pok1
            Console.WriteLine(pokemon2.name + " slår " + pokemon1.name + " med " + pokemon2.damage);
            pokemon1.health = pokemon1.health - pokemon2.damage;
            Console.WriteLine(pokemon1.name + " har " + pokemon1.health + " hälsa kvar ");

            // pok1 slår pok2
            Console.WriteLine(pokemon1.name + " slår " + pokemon2.name + " med " + pokemon1.damage);
            pokemon2.health = pokemon2.health - pokemon1.damage;
            Console.WriteLine(pokemon2.name + " har " + pokemon2.health + " hälsa kvar ");

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
            Console.WriteLine();
            Console.WriteLine("Vinnaren är " + winner.name);
            winner.FullHeal();
            Console.WriteLine();
            Console.WriteLine("Tryck på en tangent för att fortsätta...");
            Console.ReadLine();
        }
        return winner;
    }
}
