using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Transport
    {
        private int Year;
        //public int Weight;
        public int Weight { get; private set; }
        //private int Speed;
        protected string Name;

        private int _speed;
        public int Speed 
        { 
            get
            {
                return _speed;
            }
            set
            {
                if (value > 400)
                    _speed = 400;
                else if (value < 0)
                    _speed = 0;
                else
                    _speed = value;
            }
        }

        public Transport(int year,int weight, int speed)
        {
            Year = year;
            Weight = weight;
            Speed = speed;
        }

        public string GetYear()
        {
            if (Year > 2010)
                return "Teze transport";

            return "Kohne transport";
        }

        //public int GetSpeed()
        //{
        //    //if (Speed < 0)
        //    //    return 0;

        //    return Speed;
        //}

        //public void SetSpeed(int speed)
        //{
        //    if (speed > 400)
        //        Speed = 400;
        //    else if (speed < 0)
        //        Speed = 0;

        //    Speed = speed;
        //}

        protected void Print()
        {
            //Name = "Print";
            Console.WriteLine("Print");
        }

        public virtual string GetInfo()
        {
            return $"{Year} {Weight} {Speed}";
        }
    }
    
}
