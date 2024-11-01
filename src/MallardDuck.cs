class MallardDuck : Duck, IFlyable, IQuackable, ISwimmable, IFeedable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Mallard Duck");
    }

    public void Feed()
    {
        Console.WriteLine("Mallard Duck is eating out of your hand!");
    }

    public void Fly()
    {
        Console.WriteLine("Mallard Duck is flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }

    public void Swim()
    {
        Console.WriteLine("Mallard Duck is swimming");
    }
}