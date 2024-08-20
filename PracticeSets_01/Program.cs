using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive);
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative);
            }
            else
            {
                Console.WriteLine($"{num} is neither negative nor positive");
            }

        }
    }
}
