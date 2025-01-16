using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {

        public int Z;


        public Child(int x ,int y ,int z):base(x,y)
        {
            this.Z = z;

        }
        public override string ToString()
        {
            return $"{base.ToString()}, Z is {Z}";
        }

        public new int Product()
        {
            return base.Product()*Z;
        }
    }
}
