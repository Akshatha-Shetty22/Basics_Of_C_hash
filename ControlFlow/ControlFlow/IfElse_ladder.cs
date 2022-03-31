using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class IfElse_ladder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter item Name:(food|services|ornaments):");
            string str = Console.ReadLine();
            str = str.ToLower();
            if(str=="food")
            {
                Console.WriteLine("Gst=5%");
            }
            else if(str=="services")
            {
                Console.WriteLine("Gst=8%");
            }
            else if(str=="ornaments")
            {
                Console.WriteLine("Gst=3%");
            }
            else
            {
                Console.WriteLine("invalid item");
            }
        }
    }
}
