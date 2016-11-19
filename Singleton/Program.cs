using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler instance = ChocolateBoiler.GetInstance("First Instance");
            Console.WriteLine(instance.GetName());

            instance = ChocolateBoiler.GetInstance("Second Instance");
            Console.WriteLine(instance.GetName());

            Console.ReadKey();


        }
    }
}
