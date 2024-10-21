using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimUDuck.Ducks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MallarDuck mallarduck = new MallarDuck();
            mallarduck.Display();

            RedHeadDuck redheadduck =new RedHeadDuck();
            redheadduck.Display();

           RubberDuck rubberduck= new RubberDuck();
            rubberduck.Display();

           DecoyDuck decoyduck= new DecoyDuck();
            decoyduck.Display();


        }
    }
}
