using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class HoldsChosenStrategy
    {
        private IStrategy _strategy; //instans variabel

        public void SetStrategy (IStrategy strategy)
        {
            _strategy = strategy;
        }
        public int ExecuteStrategy(int num1, int num2)
        {
            return _strategy.Execute(num1, num2);
        }
    }
}
