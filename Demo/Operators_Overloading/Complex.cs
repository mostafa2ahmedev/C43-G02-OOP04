using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operators_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imaginary     { get; set; }




        #region Binary Operators
        public static Complex operator +(Complex left, Complex right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) + (right?.Imaginary ?? 0)
            };


        } 
        #endregion

        #region Unary Operators
        public static Complex operator ++(Complex c)
        {

            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imaginary = (c?.Imaginary ?? 0)
            };


        }

        #endregion




        public override string ToString()
        {
            return $"{Real} + i{Imaginary}";
        }
    }
}
