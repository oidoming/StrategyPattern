using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Nadar
{
    internal class Float : INadar
    {
        public void nadar()
        {
            Console.WriteLine("Estoy flotando\n");
        }
    }
}
