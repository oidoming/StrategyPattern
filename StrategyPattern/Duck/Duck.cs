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
    internal abstract class Duck
    {
        public IGraznar? graznar;
        public INadar? nadar;
        public IVolar? volar;

        public abstract void display();

        public void setGraznar(IGraznar gb)
        {
            this.graznar = gb;
        }

        public void setNadar(INadar nb)
        {
            this.nadar = nb;
        }

        public void setVolar(IVolar vb)
        {
            this.volar = vb;
        }
        public void performGraznar()
        {
            graznar.graznar();
        }

        public void performNadar()
        {
            nadar.nadar();
        }

        public void performVolar()
        {
            volar.volar();
        }
    }
}
