using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck_APP.Interfaces;

namespace Duck_APP
{
    //Context , class will delegate what they will do
    public abstract class Duck
    {
        public IFlyBehavior flybehavior;
        public IQuackBehavior quackBehavior;
      

        public void SetFlyBehavior (IFlyBehavior fb)
        {
            flybehavior = fb;
        }
        public void SetQuackBehavior (IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public abstract void Display();

        public void performFly()
        {
            flybehavior.Fly();

        }

        public void performQuack()
        {
            quackBehavior.QuackSound();
        }
       


        public void Swim()
        {
            Console.WriteLine("Duck: *SWIMMING*");

        }

    }
}
