class RedHeadDuck : Duck, IFlyable, IQuackable, ISwimmable, IFeedable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Red Head Duck");
    }

    public void Feed()
    {
        Console.WriteLine(" The Red head duck is being fed");
    }

    public void Fly()
    {
        Console.WriteLine("Red Head Duck is flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }

    public void Swim()
    {
        Console.WriteLine("Red Head Duck is swimming!");
    }
}