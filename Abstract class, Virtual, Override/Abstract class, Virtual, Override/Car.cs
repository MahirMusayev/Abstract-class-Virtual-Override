using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override
{
    internal class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElctricCar { get; set; }

        public Car(string factoryname, string model, string color, double drivetimr, double drivepath, int doorcount, bool iselectriccar) : base(factoryname, model, color, drivetimr, drivepath)
        {
            DoorCount = doorcount;
            IsElctricCar = iselectriccar;
        }
        public override string DefineNatureHarmness()
        {
            if (IsElctricCar)
            {
                return "low";
            }
            else
            {
                return "high";
            }
        }

    }
}
