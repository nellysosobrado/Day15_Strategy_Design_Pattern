using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelStrategy.Strategies
{
    public class Car : TravelStrategy
    {
        public Car() //Constrcutor
        {
            _kilometerCost = 25; //Start value
        }
        public override decimal Drive(int km) //Method
        {//Abstract method, inheriting a abstract method needs to be overriten 
            return km * _kilometerCost;
        }
    }
}
