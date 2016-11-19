using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Beverage
    {
        public string Description = "Unknown Beverge";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Coast();
    }
}
