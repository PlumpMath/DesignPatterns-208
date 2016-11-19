using Factory.PizzaIngredients;

namespace Factory.PizzasStyle.ConcretePizza
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
         }

        public override void Prepare()
        {
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSaurce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggieses = _ingredientFactory.CreateVeggies();
            Clam = _ingredientFactory.CreateClams();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}
