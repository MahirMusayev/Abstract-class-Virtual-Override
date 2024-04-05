using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_class_taski
{
    internal class Student : Person
    {
        private string _uniName;
        private int _course;
        private bool _isGraduated;
        public string UniName
        {
            get { return _uniName; }
            set { _uniName = value; }
        }
        public int Course
        {
            get { return _course; }
            set
            {
                if (value > 0 && value < 5)
                {
                    _course = value;
                    if (_course == 4)
                    {
                        _isGraduated = true;
                    }
                }
            }
        }
        public bool IsGraduated
        {
            get { return _isGraduated; }
        }
        public Student(string name, string surname, int age) : base(name, surname, age) { }
        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {UniName}");
        }
    }
}
