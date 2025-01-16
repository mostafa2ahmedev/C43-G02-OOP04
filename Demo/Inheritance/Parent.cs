using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }



      

        public Parent(int x , int y )
        {
            this.X = x;
            this.Y = y;
            
        }

        public  int Product() {
            return X * Y;
        }
        public override string ToString()
        {
            return $"X is : {X}. Y is : {Y}";
        }
    }
}
