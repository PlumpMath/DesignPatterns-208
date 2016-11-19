using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage = null;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
            Description = "Soy";
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _beverage.GetDescription(), Description);
        }

        public override double Coast()
        {
            return 0.15 + _beverage.Coast();
        }
    }
}
