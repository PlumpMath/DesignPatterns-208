using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.BehaviorInterfaces;

namespace Strategy.Behaviors
{
    public class MuteQuack : IQuackBehavior 
    {
        public void Quackk()
        {
            Console.WriteLine("Silence");
        }
    }
}
