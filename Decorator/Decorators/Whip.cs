using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage = null;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
            Description = "Whip";
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _beverage.GetDescription(), Description);
        }

        public override double Coast()
        {
            return 0.10 + _beverage.Coast();
        }
    }
}
