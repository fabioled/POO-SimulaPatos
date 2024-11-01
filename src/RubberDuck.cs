class RubberDuck : Duck, IQuackable, IDuckThatSwims
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Rubber Duck");
    }


    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }
    public void Swim(){
        Console.WriteLine("Pato que nada");
    }
}