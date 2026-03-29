using System;

public abstract class Pet
{
    public string Name { get; set; }
    public int Hunger { get; set; } = 50;
    public int Happiness { get; set; } = 50;
    public int Health { get; set; } = 50;
    public int Energy { get; set; } = 50;

    public bool IsAlive => Health > 0 && Hunger > 0;

    public Pet(string name)
    {
        Name = name;
    }

    public virtual void Feed()
    {
        Hunger += 10;
        Console.WriteLine($"{Name} is eating 🍗");
    }

    public virtual void Play()
    {
        Happiness += 10;
        Energy -= 5;
        Console.WriteLine($"{Name} is playing 🎮");
    }

    public virtual void Heal()
    {
        Health += 10;
        Console.WriteLine($"{Name} is healing ❤️");
    }

    public virtual void Sleep()
    {
        Energy += 15;
        Console.WriteLine($"{Name} is sleeping 😴");
    }

    public virtual void DecreaseStats()
    {
        Hunger -= 2;
        Happiness -= 2;
        Energy -= 2;
    }

    public virtual void ShowStatus()
    {
        Console.WriteLine($"\n{Name} STATUS:");
        Console.WriteLine($"Hunger: {Hunger}");
        Console.WriteLine($"Happiness: {Happiness}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Energy: {Energy}\n");
    }
}