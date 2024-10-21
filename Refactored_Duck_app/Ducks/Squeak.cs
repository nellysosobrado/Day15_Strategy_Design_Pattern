using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactored_Duck_app.Ducks
{
    public class Squeak : IQuackBehavior
    {
        public void QuackSound()
        {
            Console.WriteLine("RubberDuck: *squeaks*");
        }
    }
}
