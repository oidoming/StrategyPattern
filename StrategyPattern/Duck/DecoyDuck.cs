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
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.graznar = new Mute();
            this.nadar = new SwimmingNoWay();
            this.volar = new FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("Soy un Deckoy Duck...\n");
        }
    }
}
