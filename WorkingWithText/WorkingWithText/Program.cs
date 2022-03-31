using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class Program
    {
        //demo on using string class
        static void Main(string[] args)
        {
            string str1 = "welcome";
            Console.WriteLine(str1);
            
            char[] chars = { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
            string msg = new string(chars);
            Console.WriteLine(msg);
            //string is immutable datatype
            //If you assign new value it creates new block of memory
            //Instead of modifying existing string,it creates a new block of memory
            //Performance type it's not a good practice
            str1 += "\nHello World";
            Console.WriteLine(str1);


            //StringBuilder object is mutable

            StringBuilder sb = new StringBuilder();
            sb.Append("welcome");
            sb.Append(" world");
            Console.WriteLine(sb.ToString());

        }
    }
}
