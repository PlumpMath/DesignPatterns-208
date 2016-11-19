using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Behaviors;
using Strategy.Ducks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallarDuck = new MallarDuck();
            mallarDuck.Display();
            mallarDuck.PerformQuack();
            mallarDuck.PerformFly();

            Console.WriteLine();

            Duck modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.PerformQuack();
            modelDuck.PerformFly();
            //динамичекое изменение поведения во время выполнения
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();

            Console.ReadKey();
        }
    }
}
