using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.BehaviorInterfaces;

namespace Strategy.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public void Quackk()
        {
            Console.WriteLine("Quack!!!");
        }
    }
}
