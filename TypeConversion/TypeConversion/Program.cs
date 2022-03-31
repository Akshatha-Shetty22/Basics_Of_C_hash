using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 50;
            double d = num;
            Console.WriteLine($"double={d}");
            object obj = num;//Assigning value type to object type it's called type-boxing.This is also implicit type casting
            Console.WriteLine($"Object={obj}");
            //obj is reference type it holds memory adress of num
            //No data loss because double can hold integer value
            //This is impicit type casting

            
        }
    }
}
