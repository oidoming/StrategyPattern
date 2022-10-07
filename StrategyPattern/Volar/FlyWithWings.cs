using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Volar
{
    internal class FlyWithWings : IVolar
    {
        public void volar()
        {
            Console.WriteLine("Estoy volando\n");
        }
    }
}
