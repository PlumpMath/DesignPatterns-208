using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void brew()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
