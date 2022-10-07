using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Graznar
{
    internal class Squeeze : IGraznar
    {
        public void graznar()
        {
            Console.WriteLine("Squeeze!\n");
        }
    }
}
