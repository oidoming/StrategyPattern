using StrategyPattern.Graznar;
using StrategyPattern.Nadar;
using StrategyPattern.Volar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Duck
{
    internal class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            this.graznar = new Quack();
            this.nadar = new FrontCrawl();
            this.volar = new Levitate();
        }

        public override void display()
        {
            Console.WriteLine("Soy un Red Head Duck...\n");
        }
    }
}
