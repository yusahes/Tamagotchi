using System;
using System.Threading;

public class GameService
{
    public Pet pet;

    public void Start()
    {
        Console.Write("Choose pet (1-Dog, 2-Cat): ");
        var choice = Console.ReadLine();

        Console.Write("Enter pet name: ");
        string name = Console.ReadLine();

        pet = choice == "1" ? new Dog(name) : new Cat(name);

        GameLoop();
    }

    private void GameLoop()
    {
        while (pet.IsAlive)
        {
            pet.DecreaseStats();

            Console.WriteLine("1.Feed 2.Play 3.Heal 4.Sleep 5.Status 6.Save 7.Load 0.Exit");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1": pet.Feed(); break;
                case "2": pet.Play(); break;
                case "3": pet.Heal(); break;
                case "4": pet.Sleep(); break;
                case "5": pet.ShowStatus(); break;
                case "6": SaveManager.Save(pet); break;
                case "7": pet = SaveManager.Load(); break;
                case "0": return;
            }

            Thread.Sleep(1000);
        }

        Console.WriteLine("💀 Your pet has died...");
    }
}