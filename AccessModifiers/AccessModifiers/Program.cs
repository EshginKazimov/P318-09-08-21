using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Access modifiers

            #region Public - class, all members (field, methods, property)

            //Car bmw = new Car(2016, colour: "Yellow", weight: 3000, speed: 260);
            //Car bmw = new Car(2016, 3000, 260, "Yellow");
            //Console.WriteLine(bmw.Colour);
            //Console.WriteLine(bmw.Year);
            //Console.WriteLine(bmw.GetInfo());
            //bmw.Test();

            #endregion

            #region Private - class, all members

            //Car bmw = new Car(2016, 3000, 260, "Yellow", 5000);
            //Console.WriteLine(bmw.GetInfo());
            //Console.WriteLine(bmw.MaxMileage);
            //bmw.Test();

            #endregion

            #region Protected

            //instance almaq
            //Car bmw = new Car(2016, 3000, 260, "Yellow", 5000);
            //bmw.Print();
            //bmw.Name = "";
            //Console.WriteLine(bmw.Name);

            #endregion

            #region Properties

            //Car bmw = new Car(2016, 3000, -500, "Yellow", 5000);
            //Console.WriteLine(bmw.Speed);
            ////bmw.Weight = 100;
            //Console.WriteLine(bmw.Weight);
            ////Console.WriteLine(bmw.Year);
            ////bmw.SetSpeed(300);
            ////Console.WriteLine(bmw.GetSpeed());
            ////if (bmw.Speed < 0)
            ////    bmw.Speed = 400;
            ////else if (bmw.Speed > 400)
            ////    bmw.Speed = 400;

            //Bus mercedes = new Bus(2010, 4000, 160, 44);
            ////mercedes.Shift = "";
            //Console.WriteLine(mercedes.Shift);

            Teacher kamran = new Teacher();
            kamran.Name = "Kamran";
            kamran.Age = 20;
            //kamran.a = 10;
            Console.WriteLine(kamran.Age);

            #endregion

            #endregion
        }
    }
}
