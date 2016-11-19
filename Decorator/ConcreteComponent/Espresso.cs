using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Coast()
        {
            return 1.99;
        }
    }
}
