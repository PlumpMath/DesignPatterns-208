using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }
        public override double Coast()
        {
            return 0.99;
        }
    }
}
