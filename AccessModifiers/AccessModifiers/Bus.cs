using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Bus : Transport
    {
        public int PassengerCount;
        public string Shift { get; }

        //public readonly string Shift;

        public Bus(int year, int weight, int speed, int passengerCount) :base(year, weight, speed)
        {
            PassengerCount = passengerCount;
            Name = "Bus";
            Shift = "Night";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " " + PassengerCount;
        }
    }

}
