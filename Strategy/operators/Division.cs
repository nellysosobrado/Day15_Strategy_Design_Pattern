using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.operators
{
    public class Division : IStrategy
    {
        public int Execute(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
