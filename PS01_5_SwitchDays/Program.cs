using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {

            double pi = 3.14;
            double radius = 5;
            double area;
            double perimeter;

            Console.WriteLine("Select an Action:\nA. Find Are\n.P Calculate Perimeter\n.X Exit");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "A:
                    area = pi * (radius**2);
                    Console.WriteLine($"Area : {area}")
                    break;
                case "P":
                    perimeter =2 * pi * radius;
                    Console.WriteLine($"Perimeter: {perimeter}")
                    break;
                case "X":
                    Console.WriteLine("Exiting Program...")
                    break;
               

            }
        }
    }
}
