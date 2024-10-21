namespace Duck_APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Duck mallard= new MallarDuck();
            Console.WriteLine("Mallard duck");
            mallard.performQuack();
            mallard.performFly();

            Console.WriteLine("---------");
            Duck modelduck = new ModelDuck();
            Console.WriteLine("Model duck");
            modelduck.performQuack();
            modelduck.performFly();
            modelduck.SetFlyBehavior(new FlyRocketPowered());
            modelduck.performFly();

        }
    }
}
