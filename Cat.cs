public class Cat : Pet
{
    public Cat(string name) : base(name) { }

    public override void Play()
    {
        base.Play();
        Console.WriteLine($"{Name} is chasing a laser 🐈");
    }
}