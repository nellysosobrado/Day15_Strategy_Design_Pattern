using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelStrategy
{
    //Context, manages which strategi we want to use
    public class TravelPlanner
    {
        private TravelStrategy _travelStrategy;//Instans variabel, field

        public void SetTravelStrategy(TravelStrategy travelStrategy) //Method
        {
            _travelStrategy = travelStrategy;

        }
        public void Drive(int km) //Calls method 
        {
            var cost = _travelStrategy.Drive(km);//Calls method, with a parameter to TravelStrategy class
            Console.WriteLine("This journey will cost:" + cost); //Results
        }

    }
}
