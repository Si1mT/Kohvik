using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class Cake
    {
        public string Name;
        protected int Grams;
        protected int Calories;
        protected double Price;

        public virtual void Eat()
        {
            Console.WriteLine("do you want to eat this yes/no");
            var answer = Console.ReadLine();
            if (answer == "yes")//need to add a while loop to go back to the question
            {
                Console.WriteLine("eat " + Name);
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
