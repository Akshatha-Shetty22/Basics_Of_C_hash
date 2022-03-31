using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variablesdemo
{
    //This program demonstatrates how to use constants
    class ConstDemo
    {
        static void Main()
        {
            //Must be assigned at the time of declaration
            const double PI = 3.14;
            int r = 5;
            double aoc = (2 * r * PI);
            Console.WriteLine($"Area of circle={aoc}");
            
        }

    }
}
