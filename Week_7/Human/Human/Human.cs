using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Human
    {
        public int age;
        public int height;

        public virtual void favorite()
        {
            Console.WriteLine("food");
        }
    }

    class Man : Human
    {
        public override void favorite()      // public new void favorite()
        {
            Console.WriteLine("car");
        }
    }

    class Woman : Human
    {
        public override void favorite()     // public new void favorite()
        {
            Console.WriteLine("jewel");
        }
    }
}

