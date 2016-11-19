
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.ConcreteComponent;
using Decorator.Decorators;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine("Description: {0} \r\n Coast: {1}", beverage.GetDescription(), beverage.Coast());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine("Description: {0} \r\n Coast: {1}", beverage2.GetDescription(), beverage2.Coast());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine("Description: {0} \r\n Coast: {1}", beverage3.GetDescription(), beverage3.Coast());

            Console.ReadKey();
        }
    }
}
