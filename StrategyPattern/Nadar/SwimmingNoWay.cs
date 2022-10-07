using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Nadar
{
    internal class SwimmingNoWay : INadar
    {
        public void nadar()
        {
            Console.WriteLine("No puedo nadar\n");
        }
    }
}
