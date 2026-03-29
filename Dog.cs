public class Dog : Pet
{
    public Dog(string name) : base(name) { }

    public override void Play()
    {
        base.Play();
        Console.WriteLine($"{Name} is fetching a ball 🐕");
    }
}