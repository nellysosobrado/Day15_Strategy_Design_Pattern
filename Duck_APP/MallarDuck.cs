using Duck_APP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck_APP.Interfaces;
using Duck_APP.Strategies;


namespace Duck_APP
{
    public class MallarDuck : Duck
    {
        //public IQuackBehavior quackBehavior;
        //public IFlyBehavior flyBehavior;

        public MallarDuck()//construcotr
        {
            quackBehavior =new Quack();
            flybehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck");
        }
       
        
    }
}
