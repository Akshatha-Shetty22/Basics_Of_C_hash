using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//demonstrating the use of goto label
namespace ControlFlow
{
    class GotoStatement
    {
        static void Main(string[] args)
        {
       start:   Console.WriteLine("Please enter item Name:(food|services|ornaments):");
            string str = Console.ReadLine();
            str = str.ToLower();
            /* char c = 'a';
             c = char.ToUpper(c);*/
            switch (str)
            {
                case "food":
                    Console.WriteLine("Gst=5%");
                    break;
                case "services":
                    Console.WriteLine("Gst=8%");
                    break;
                case "ornaments":
                    Console.WriteLine("Gst=3%");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine("Do you want to continue?(yes/no)");
            string str1 = Console.ReadLine();
            str1 = str1.ToLower();
            if(str1=="yes")
            {
                goto start;
            }

        }
    }
}
