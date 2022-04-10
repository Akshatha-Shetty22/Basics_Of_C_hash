using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Application
{
    class Subject
    {
        private string _subname;

        public string SubName
        {
            get { return _subname; }
            set { _subname = value; }
        }
        private string _scode;

        public string Scode
        {
            get { return _scode; }
            set { _scode = value; }
        }
        private Teacher _steacher;
        public Teacher STeacher
        {
            get { return _steacher; }
            set { _steacher = value; }
        }
        public Subject(string n, string c, Teacher t)
        {
            _subname = n;
            _scode = c;
            _steacher = t;
        }
    }
}
