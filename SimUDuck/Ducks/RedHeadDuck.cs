using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Ducks
{
    public class RedHeadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("I am a redheadduck");
            Quack();
            Swim();
        }
        public override void Fly()
        {
            Console.WriteLine("RedHeadDuck: *Flying*");
        }
        public override void Quack()
        {
            Console.WriteLine("RedHeadDuck: *quack*");
        }
        

        
    }
}
