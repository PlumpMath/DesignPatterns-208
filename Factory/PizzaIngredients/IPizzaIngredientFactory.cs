using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.PizzaIngredients.IngredientsInterfaces;

namespace Factory.PizzaIngredients
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSaurce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }
}
