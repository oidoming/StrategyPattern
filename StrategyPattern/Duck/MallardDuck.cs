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
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.graznar = new Quack();
            this.nadar = new FrontCrawl();
            this.volar = new FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("Soy un Mallard Duck...\n");
        }
    }
}
