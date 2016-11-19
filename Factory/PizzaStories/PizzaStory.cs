using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;
using Factory.PizzasStyle;

namespace Factory.PizzaStories
{
    public abstract class PizzaStory
    {
        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza = null;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType type);
    }
}
