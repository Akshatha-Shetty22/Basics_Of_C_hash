using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variablesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 100;
            sbyte sb= -100;//signedbyte-can hold negative as well a positive values
            short s = 1233;
            int i = 12345;
            uint ui= 123;//Can hold only positive number
            long l = 4322344;
            ulong u= 1223444; //holds only positive number;
            double d = 345.45;
            string str = "welcome";
            char c = 'A';
            bool flag = true;
            Console.WriteLine($"byte={ b}\nshort={ s}\nint={i}\nlong={l}\ndouble={d}\nstring={str}\nchar={c}\nbool={flag}");
            //object keyword can hold any datatype-It is the base type of all types in .Net
            //All types are derived from System.Object
            object intObj = 34;
            object charobj = 'C';
            object boolObj = false;
            object strObj = "welcome";
            Console.WriteLine($"IntObj={intObj}\ncharObj={charobj}\nboolObj={boolObj}\nstrObj={strObj}\n");
            Console.ReadLine();
        }
    }
}
