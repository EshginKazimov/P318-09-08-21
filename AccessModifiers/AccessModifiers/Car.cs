using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Car : Transport
    {
        public string Colour;
        private int MaxMileage { get; }
        //private readonly int MaxMileage;

        public Car(int year, int weight, int speed, string colour, int maxMileage) : base(year, weight, speed)
        {
            Colour = colour;
            MaxMileage = maxMileage;
            Name = "Car";
        }

        private void Test()
        {
            //Print();
            //MaxMileage = 100;

            Console.WriteLine(MaxMileage);
        }

        public override string GetInfo()
        {
            Test();
            return base.GetInfo() + " " + Colour;
        }

        //private class Demo
        //{
        //    public string Test;
        //}
    }
}
