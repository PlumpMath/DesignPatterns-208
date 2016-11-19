﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.BehaviorInterfaces;

namespace Strategy.Behaviors
{
    public class FlyNoWay : IFlyBehavior 
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!!!");
        }
    }
}
