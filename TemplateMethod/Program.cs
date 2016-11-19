using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine();

            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
