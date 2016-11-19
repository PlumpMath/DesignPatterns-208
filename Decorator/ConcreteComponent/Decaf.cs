using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }
        public override double Coast()
        {
            return 1.05;
        }
    }
}
