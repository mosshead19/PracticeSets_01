using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 57;
            int income = 20000;

            bool YoungPro = age >= 25 && age <= 35 && income > 50000;
            bool midAgePro = age >= 36 && age <= 55 && income > 70000;
            bool seniorPro = age >= 56 && income < 30000;




            if (YoungPro)
            {
                Console.WriteLine("Category: Young Professional");

            }
            else if (midAgePro)
            {
                Console.WriteLine("Category: Middle-Aged Professional");
            }
            else if (seniorPro)
            {
                Console.WriteLine("Category: Senior Citizen Professional");
            }
            else
            {
                Console.WriteLine($"Category not available");
            }



            Console.ReadLine();
        }
    }
}
