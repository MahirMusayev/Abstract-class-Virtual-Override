using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_class_taski
{
    internal class Doctor : Employe
    {
        public Doctor(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public void Heal(Person person)
        {
            Console.WriteLine("Healed");

        }

    }
}
