using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_2_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            bool even = num % 2 == 0;

            if (even)
            {
                Console.WriteLine($"The number {num} is even");
            }
            else
            {
                Console.WriteLine($"The number {num} is odd");
            }
            Console.ReadLine();
        }
    }
}
