using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class AbstractFactoryCars
    {
        public abstract void Motor();
        public abstract void Renk();
        public abstract void Lastikler();
        public abstract void Test();
        public abstract string IslemSonuc();

    }
}
