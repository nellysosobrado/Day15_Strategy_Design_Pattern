using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_APP.Strategies
{
    public class MuteQuack
    {
        public void QuackSound()
        {
            
            Console.WriteLine("Duck: cannot quack :(");
        }
    }
}
