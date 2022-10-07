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
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.graznar = new Quack();
            this.nadar = new Float();
            this.volar = new FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("Soy un Model Duck...\n");
        }
    }
}
