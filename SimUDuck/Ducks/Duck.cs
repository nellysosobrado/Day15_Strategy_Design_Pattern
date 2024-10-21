using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Ducks
{
    public abstract class Duck
    {

        public abstract void Quack();
        public void Swim()
        {
            Console.WriteLine("Duck: *SWIMMING*");

        }

        public abstract void Fly();

        public abstract void Display();


    }
}
