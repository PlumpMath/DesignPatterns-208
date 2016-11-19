using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.PizzaIngredients.Ingredients;
using Factory.PizzaIngredients.IngredientsInterfaces;

namespace Factory.PizzaIngredients.IngredientFactories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSaurce()
        {
            return new MarinaroSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {new Garlic(), new Onion(), new Mushroom(), new RedPepper()};
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
    }
}
