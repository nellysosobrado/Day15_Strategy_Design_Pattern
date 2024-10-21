using TravelStrategy.Strategies;

namespace TravelStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myTravelPlanner = new TravelPlanner();//New instans

            myTravelPlanner.SetTravelStrategy(new Car());

            myTravelPlanner.Drive(1100);

            Console.ReadKey();
        }
    }
}
