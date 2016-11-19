
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Behaviors;

namespace Strategy.Ducks
{
    public class MallarDuck : Duck
    {
        public MallarDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallar duck!!!");
        }
    }
}
