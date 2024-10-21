using Strategy.operators;
using System.ComponentModel;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoldsChosenStrategy strategy =new HoldsChosenStrategy();

            strategy.SetStrategy(new Addition());
            Console.WriteLine("Addition: 5+5 = " + strategy.ExecuteStrategy(5,5));

            Console.ReadLine();
        }
    }
}
