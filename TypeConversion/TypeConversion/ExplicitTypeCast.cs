using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    //This program demonstartes how to perform explicit type casting
    //This may cause dataloss ,depends on your value
    class ExplicitTypeCast
    {
        static void Main(string[] args)
        {
            object obj = 67;
            //int num = obj;//This gives error cause int cannot hold object value
            int num = Convert.ToInt32(obj);
            //or
            int num1 = (int)obj;//unboxing
            Console.WriteLine($"Integer values={num} and {num1}");

            //double to int
            double d = 56.7;
            int n = (int)d;//Output will be 56,so there's dataloss
            Console.WriteLine($"Double to Integer value={n}");
            //using convert class
            int n1 = Convert.ToInt32(d);
            Console.WriteLine($"Double to Integer value using convert class={n1}");

            //Convert to string
            char c = 'A';
            string str = Convert.ToString(c);
            Console.WriteLine($"string={str}");
            //or
            string str1 = c.ToString();
            Console.WriteLine($"string={str1}");

            int num2 = 56;
            string str2 = Convert.ToString(num2);
            Console.WriteLine($"Num to string ={str2}");


        }
    }
}
