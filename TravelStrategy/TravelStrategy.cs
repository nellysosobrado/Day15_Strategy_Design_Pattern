using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelStrategy
{
    //Abstract class: A un-finished blueprint, where details needs to be implemented inside of the classes that will inherit it.
    public abstract class TravelStrategy 
    {
        public int _kilometerCost;



        //Abstract method, that needs to be implemented inside of the class that will inherit TravelStrategy class
        //Means the class that will inherit will have to write their own version of Drive()
        public abstract decimal Drive(int km); //Method

    }
}
