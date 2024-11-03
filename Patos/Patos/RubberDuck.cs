using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos
{
    internal class RubberDuck : Pato, Iquackble
    {

        public override void Display()
        {
            Console.WriteLine("Displaying a RubberDuck");
        }

        public void Quack()
        {
            throw new NotImplementedException();
        }
        public void Swim()
        {
            Console.WriteLine("The duck is swimming");
        }
    }
}
