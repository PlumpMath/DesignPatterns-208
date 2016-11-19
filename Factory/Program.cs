using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.PizzaStories;
using Factory.PizzasStyle;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStory pizzaStory = new NYPizzaStory();
            pizzaStory.OrderPizza(PizzaType.Chesse);

            //pizzaStory = new ChicagoPizzaStory();
            //pizzaStory.OrderPizza(PizzaType.Chesse);

            
            Console.ReadLine();
        }
    }
}
