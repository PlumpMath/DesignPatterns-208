using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.BehaviorInterfaces;

namespace Strategy.Ducks
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys.");
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }
        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quackk();
        }
    }
}
