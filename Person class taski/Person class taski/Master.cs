using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_class_taski
{
    internal class Master : Student
    {
        string _mastercourse;
        string _masteruniname;
        public string Mastercourse
        {
            get { return _mastercourse; }
            set { _mastercourse = value; }
        }
        public string Masteruniname
        {
            get { return _masteruniname; }
            set { _masteruniname = value; }
        }
        public Master(string name, string surname, int age) : base(name, surname, age)
        {
        }
    }
}
