using System;

public class Pokemon
{
    // Egenskaper (attribut)
    public string Name;
    public int health = 100;
    public int damage = 20;

    // Konstruktor
    public Pokemon(string name)
	{
        Name = name;
    }

    // Övriga metoder som innehåller arbete som Pokemons kan utföra
    public void PrintInfo()
    {
        Console.WriteLine(Name + ", Health: " + health + ", Damage: "+damage);
    }
}
