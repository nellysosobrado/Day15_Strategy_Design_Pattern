using Refactored_Duck_app.Ducks;

namespace Refactored_Duck_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyWithWings duckswithwings=new FlyWithWings();
            duckswithwings.Fly();
            Console.WriteLine("--------------");

            FlyNoWay duckswithnowings= new FlyNoWay();
            duckswithnowings.Fly();
            Console.WriteLine("--------------");

            Quack duckwithsound=new Quack();
            duckwithsound.QuackSound();
            Console.WriteLine("--------------");

            Squeak rubberducksound = new Squeak();
            rubberducksound.QuackSound();
            Console.WriteLine("--------------");

            MuteQuack duckwithnosound = new MuteQuack();
            duckwithnosound.QuackSound();
            Console.WriteLine("--------------");
        }
    }
}
