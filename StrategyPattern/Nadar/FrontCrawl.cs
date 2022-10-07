using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Nadar
{
    internal class FrontCrawl : INadar
    {
        public void nadar()
        {
            Console.WriteLine("Estoy nadando hacia enfrente\n");
        }
    }
}
