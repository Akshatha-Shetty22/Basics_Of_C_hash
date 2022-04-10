using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Application
{
    class Display_Subject
    {
        public void Display_Details()
        {
            List<Teacher> lt = new List<Teacher>();
            string[] tname = new string[] { "anitha", "asha", "keertana" };
            string[] tclass = new string[] { "7", "6", "7" };
            string[] tsection = new string[] { "A", "B", "B" };
            //Student[] s = new Student[n];
            for (int i = 0; i < 3; i++)
            {
                Teacher t = new Teacher(tname[i], tclass[i], tsection[i]);
                lt.Add(t);

            }


            List<Subject> sub = new List<Subject>();
            string[] subname = new string[] { "Maths", "English", "Kannada", "Science", "Social Science", "Hindi" };
            string[] subcode = new string[] { "m101", "e101", "k101", "s101", "so101", "h101" };
            Teacher[] subteacher = new Teacher[] { lt[0], lt[1], lt[2], lt[0], lt[1], lt[2] };
            //Student[] s = new Student[n];
            for (int i = 0; i < 6; i++)
            {
                Subject subject = new Subject(subname[i], subcode[i], subteacher[i]);
                sub.Add(subject);

            }

            Console.WriteLine("Enter the teacher Name:");
            string teacher_name = (Console.ReadLine()).ToLower();
            Console.WriteLine($"\nSubjects taught by {teacher_name} are:");
            for (int i = 0; i < 6; i++)
            {
                if (sub[i].STeacher.TName == teacher_name)
                {
                    Console.WriteLine(sub[i].SubName);
                }
                /*if(s[i].STeacher.TName==tname)
                {
                     Console.WriteLine(s1[i].SubName);

                }*/
            }

        }
    }
}
