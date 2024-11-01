class MetalDuck : Duck, IQuackable
{
    public override void Display()
    {
        throw new NotImplementedException();
    }

    public void Quack()
    {
        Console.WriteLine("(robotic sound) QUACK. QUACK.");

    }
}