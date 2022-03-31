using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=0;i<10;i++)
            {
                // Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine(sum);

            //while loop
            int sum1 = 0;
            int j = 0;
            while(j<10)
            {
                sum1 = sum1 + j;
                j++;
            }
            Console.WriteLine(sum1);

            //do while loop
            int k = 0;
            int sum3 = 0;
            do
            {
                sum3 = sum3 + k;
                k++;

            } while (k < 10);
            Console.WriteLine(sum3);

            //foreach loop-used to iterate array of collection
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int sum4 = 0;
            foreach(int item in arr)
            {
                sum4 = sum4 + item;
            }
            Console.WriteLine(sum4);

        }
    }
}
