﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_4_PassedFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string grade = (99 >= 50) ? "Passed" : "Failed";
            Console.WriteLine(grade);

            Console.ReadLine();
        }
    }
}
