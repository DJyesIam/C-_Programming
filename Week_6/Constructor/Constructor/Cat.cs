using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
            nCat++;
        }

        public string Name;
        public string Color;

        public static int nCat = 0;
    }
}
