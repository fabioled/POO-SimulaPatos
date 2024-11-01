class RubberDuck : Duck, IQuackable, ISwimmable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Rubber Duck");
    }


    public void Quack()
    {
        Console.WriteLine("(Squish) Quack, quack!!");
    }

    public void Swim()
    {
        Console.WriteLine("The rubber duck is floating");

    }
}