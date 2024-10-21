using Duck_APP.Strategies;
using Duck_APP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_APP
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehavior = new Quack();
            flybehavior = new FlyNoWay();
            
        }
        public override void Display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
