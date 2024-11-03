using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos
{
    internal class RedHeadDuck: Pato, IFlyable, Iquackble
    {
    
    public override void Display()
    {
        Console.WriteLine("Displaying a Mallard Duck");
    }

    public void Fly()
    {
        Console.WriteLine("The Mallard Duck is flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack quack");
    }
}
}