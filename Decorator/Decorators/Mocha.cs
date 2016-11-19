using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage = null;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Description = "Mocha";
        }

        public override double Coast()
        {
            return 0.20 + _beverage.Coast();
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}",_beverage.GetDescription(), Description);
        }
    }
}
