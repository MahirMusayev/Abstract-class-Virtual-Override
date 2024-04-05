using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_class_taski
{
    internal class Employe : Person
    {
        decimal _salary;
        private double _experience;
        public override int Age
        {
            get => Age;
            set
            {
                if (value >= 18 && value < 65)
                {
                    Age = value;
                }
            }
        }
        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value >= 350)
                {
                    _salary = value;
                }
            }
        }
        public Employe(string name, string surname, int age) : base(name, surname, age) { }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name}");
        }
    }
}
