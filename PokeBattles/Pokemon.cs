using System;

public class Pokemon
{
    // Egenskaper (attribut)
    public string name;
    public int maxHealth;
    public int health;
    public int damage;

    // Konstruktor
    public Pokemon(string name, int maxHealth, int damage)
	{
        this.name = name;
        this.maxHealth = maxHealth;
        this.health = maxHealth; // Startar med full hälsa
        this.damage = damage;
    }

    // Övriga metoder som innehåller arbete som Pokemons kan utföra
    public void PrintInfo()
    {
        Console.WriteLine(name + ", Health: " + health + ", Damage: "+damage);
    }

    public void FullHeal()
    {
        health = maxHealth;
        Console.WriteLine(name + " vilade fick återfick full hälsa (" + health + ")");
    }

    // Används inte än
    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > maxHealth)
        {
            health = maxHealth; // Hälsan kan inte överstiga maxHealth
        }
    }
}
