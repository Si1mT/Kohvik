using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class Kohv
    {
        public string Name;
        protected bool Milk;
        protected int Calories;
        protected double Price;

        public virtual void Drink()
        {
            Console.WriteLine("do you want to drink this yes/no");
            var answer = Console.ReadLine();
            if (answer == "yes")//need to add a while loop to go back to the question
            {
                Console.WriteLine("drink "+Name);
            }
            else if (answer == "no")
            {
                Console.WriteLine("what then");
            }
            else
            {
                Console.WriteLine("that's not yes or no");
            }
        }
    }
}
