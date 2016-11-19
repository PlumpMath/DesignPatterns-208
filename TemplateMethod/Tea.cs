using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void brew()
        {
            Console.WriteLine("Stepping the tea");
        }
    }
}
