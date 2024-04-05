using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override
{
    internal abstract class Vehicle
    {
        string _factoryname;
        string _model;
        string _color;
        double _drivertime;
        double _drivepath;
        public string Factoryname
        {
            get { return _factoryname; }
            set
            {
                
                    _factoryname = value;
                
            }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public double Drivertime
        {
            get { return _drivertime; }
            set
            {
                
                    _drivertime = value;
                
            }
        }
        public double Drivepath
        {
            get { return _drivepath; }
            set
            {
               
                    _drivepath = value;
                
            }
        }

        protected Vehicle(string factoryname, string model, string color, double drivetimr, double drivepath)
        {
            Factoryname = factoryname;
            Model = model;
            Color = color;
            Drivertime = drivetimr;
            Drivepath = drivepath;
        }
        public double AverageSpeed()
        {
            return _drivepath / _drivertime;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory Name: {Factoryname}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Drive Time: {Drivertime} hours");
            Console.WriteLine($"Drive Path: {Drivepath} kilometers");
        }
        public override string ToString()
        {
            return $"{Factoryname} - {Model}";
        }
        public abstract string DefineNatureHarmness();
    }
}
