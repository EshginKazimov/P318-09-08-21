using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Teacher
    {
        public string Name { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 22)
                {
                    Console.WriteLine("Teacher 22-yashdan boyuk olmalidir.");
                    return;
                }

                _age = value;
            }
        }
    }
}
