using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Graznar
{
    internal class Quack : IGraznar
    {
        public void graznar()
        {
            Console.WriteLine("Quack!\n");
        }
    }
}
