using System;
using System.Collections.Generic;
using Factory.PizzaIngredients.IngredientsInterfaces;

namespace Factory.PizzasStyle
{
    public abstract class Pizza
    {
        protected string Name;
        protected IDough Dough;
        protected ISauce Sauce;
        protected IVeggies[] Veggieses;
        protected ICheese Cheese;
        protected IPepperoni Pepperoni;
        protected IClams Clam;

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string SetName(string name)
        {
            return Name;
        }
    }
}
