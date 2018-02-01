using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class Program
    {
        static void Main(string[] args)
        {
            Choose choose = new Choose();

            choose.ChooseDrink();

            Console.WriteLine();

            choose.ChooseCake();
            Console.ReadLine();
        }
    }
}
