using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStudentdetails ds = new DisplayStudentdetails();
            ds.Read_and_display();

            Display_Subject sub = new Display_Subject();
            sub.Display_Details();

            

            }


        }
    }

