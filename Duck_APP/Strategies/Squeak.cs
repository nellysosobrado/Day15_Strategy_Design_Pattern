using Duck_APP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_APP.Strategies
{
    public class Squeak : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("RubberDuck: *squeaks*");
        }
    }
}
