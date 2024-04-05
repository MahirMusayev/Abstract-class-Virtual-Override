using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_class_taski
{
    internal abstract class Person
    {
        string _name;
        string _surname;
        int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 200)
                {
                    _age = value;
                }
            }
        }

        protected Person(string name,string surname,int age)
        {
            Name= name;
            Surname = surname;
            Age = age;
            Console.WriteLine("Person ctor ise dusdu");
        }
        public abstract void GetInfo();
    }

}
