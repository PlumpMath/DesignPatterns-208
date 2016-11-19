using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.PizzaIngredients;
using Factory.PizzaIngredients.IngredientFactories;
using Factory.PizzasStyle;
using Factory.PizzasStyle.ConcretePizza;

namespace Factory.PizzaStories
{
    public class ChicagoPizzaStory : PizzaStory
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Chesse: return new CheesePizza(new NYPizzaIngredientFactory());
            }
            return null;
        }
    }
}
