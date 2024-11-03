using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos
{
    internal class MallarDuck: Pato, IFlyable, Iquackble
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

        public void Swim()
        {
            Console.WriteLine("The duck is swimming");
        }
    }
}
