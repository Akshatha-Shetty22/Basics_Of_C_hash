using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    //program demo of if-else
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Annual income:");
            double annualIncome = Convert.ToDouble(Console.ReadLine());
            if(annualIncome>=280000)
            {
                Console.WriteLine("You are liable to pay Income tax");
            }
            else
            {
                Console.WriteLine("You are not liable to pay Income tax");
            }
        }
    }
}
