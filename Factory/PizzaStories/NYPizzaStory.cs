using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.PizzaIngredients.IngredientFactories;
using Factory.PizzasStyle;
using Factory.PizzasStyle.ConcretePizza;

namespace Factory.PizzaStories
{
    // ReSharper disable InconsistentNaming
    public class NYPizzaStory : PizzaStory
    // ReSharper restore InconsistentNaming
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Chesse:
                    {
                        Pizza pizza = new CheesePizza(new NYPizzaIngredientFactory());
                        pizza.SetName("NY Style Cheese Pizza");
                        return pizza;
                    }
                case PizzaType.Veggie: return new VerggiePizza();
                case PizzaType.Clam: return new ClamPizza();
                case PizzaType.Pepperoni: return new PepperoniPizza();
            }
            return null;
        }
    }
}
