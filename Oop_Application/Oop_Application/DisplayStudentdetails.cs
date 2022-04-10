using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Application
{
    class DisplayStudentdetails
    {
        public void Read_and_display()
        {
            int n = 5;
            List<Student> ls = new List<Student>();
            string[] sname = new string[] { "Aanchal", "Bhumi", "Akshatha", "Arun", "Adithi" };
            string[] sclass = new string[] { "7", "6", "7", "8", "6" };
            string[] ssection = new string[] { "A", "B", "A", "C", "B" };
            //Student[] s = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Student s = new Student(sname[i], sclass[i], ssection[i]);
                ls.Add(s);

            }
            bool f = true;
            while (f)
            {
                Console.WriteLine("Enter the class:");
                string cl = Console.ReadLine();

                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (ls[i].SClass == cl)
                    {
                        if (k == 0)
                        {
                            Console.WriteLine($"Students in class {cl} are:");
                        }
                        Console.WriteLine(ls[i].SName);
                        k = 1;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine($"No students in class {cl}");
                }
                Console.WriteLine("\nDo you wish to continue?(yes/no)");
                string response = (Console.ReadLine()).ToLower();
                if (response == "no")
                {
                    f = false;
                }
            }
        }
    }
}
