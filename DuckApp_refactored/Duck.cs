using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp_refactored
{
    //Context
    //Duck class will delegate who does what
    public class Duck
    {
        public IFlyBehavior FlyBehavior;
        public IQuackBehavior quackBehavior;

        public void performQuack()
        {
            quackBehavior.QuackSound();
        }

       
    }
}
