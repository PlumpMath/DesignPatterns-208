using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Coast()
        {
            return 0.89;
        }
    }
}
