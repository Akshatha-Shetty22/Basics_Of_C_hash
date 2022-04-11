using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Text_Files
{
    class Program
    {
        static void Main(string[] args)
        {
        start: Console.Write("Enter 1.To add Teacher Details 2.To Update Teacher Details 3.Display all Teacher Info:");
            int choice = Convert.ToInt32(Console.ReadLine());
            Manage_Teacher_Info manageTeacher = new Manage_Teacher_Info();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Teacher Id:");
                    int teach_id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Teacher Name:");
                    string teach_name = Console.ReadLine();
                    Console.Write("Enter Teacher Class:");
                    string teach_class = Console.ReadLine();
                    Console.Write("Enter Teacher Section:");
                    string teach_section = Console.ReadLine();
                    var flag = manageTeacher.AddTeacher(new Teacher { Id = teach_id, Name = teach_name, Class = teach_class,Section=teach_section }, true);
                    if (flag)
                    {
                        Console.WriteLine("Teacher Details Added Succesfully");
                    }
                    break;
                case 2:
                    Console.Write("Enter Teacher Id to be Updated:");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    var flag1 = manageTeacher.UpdateTeacher(id1);
                    if (flag1)
                    {
                        Console.WriteLine("Teacher Details Updated Successfully");
                    }
                    break;
                case 3:

                    manageTeacher.PrintAllTeacherDetails();

                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("Do You Want to Continue:(yes/no)?");
            string response = Console.ReadLine();
            if (response.ToLowerInvariant() == "yes")
            {
                goto start;
            }

          
        }
    }
}
