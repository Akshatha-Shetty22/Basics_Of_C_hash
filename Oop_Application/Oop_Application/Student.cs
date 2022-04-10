using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Application
{
    class Student
    {
        private string _sname;

        public string SName
        {
            get { return _sname; }
            set { _sname = value; }
        }
        private string _sclass;

        public string SClass
        {
            get { return _sclass; }
            set { _sclass = value; }
        }
        private string _ssection;

        public string SSection
        {
            get { return _ssection; }
            set { _ssection = value; }
        }
        public Student(string n, string c, string s)
        {
            _sname = n;
            _sclass = c;
            _ssection = s;
        }
        

    }
}
