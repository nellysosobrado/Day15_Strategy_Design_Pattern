using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Ducks
{
    public class MallarDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("I am a mallar duck");
            Quack();
            Swim();
        }
        public override void Fly()
        {
            Console.WriteLine("Mallarduck: *Flying*");
        }
        public override void Quack()
        {
            Console.WriteLine("Mallarduck: *quak*");
        }
        
        
    }
}
