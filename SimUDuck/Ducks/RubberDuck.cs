using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Ducks
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("I'm a rubberduck");
            Fly();
            Quack();

        }
        public override void Fly()
        {
            Console.WriteLine("RubberDuck: cannot fly...");
        }
        public override void Quack()
        {
            Console.WriteLine("Rubberduck : *squeak*");

        }
        
        
    }
}
