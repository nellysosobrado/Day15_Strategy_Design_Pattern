using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Ducks
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("I'm a DecoyDuck");
            Fly();
            Quack();
        }
        public override void Fly()
        {
            Console.WriteLine("DecoyDuck: cannot fly");
        }
        public override void Quack()
        {
            Console.WriteLine("DecoyDuck: *silence*");
        }
        
    }
}
