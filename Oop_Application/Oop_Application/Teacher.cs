using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Application
{
    class Teacher
    {
        private string _tname;

        public string TName
        {
            get { return _tname; }
            set { _tname = value; }
        }
        private string _tclass;

        public string TClass
        {
            get { return _tclass; }
            set { _tclass = value; }
        }
        private string _tsection;

        public string TSection
        {
            get { return _tsection; }
            set { _tsection = value; }
        }
        public Teacher(string n,string c,string s)
        {
            _tname = n;
            _tclass = c;
            _tsection = s;
        }
    }
}
