using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        protected abstract void addCondiments();
        protected abstract void brew();

        private void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
