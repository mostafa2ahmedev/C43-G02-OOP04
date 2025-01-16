using Demo.Operators_Overloading;


namespace Demo
{
    internal class Program
    {

        //static int sum02Numbers(int x , int y) {
        //return x + y;
        //}
        //static int sum03Numbers(int x, int y,int z)
        //{
        //    return x + y + z;
        //}
        #region Poly > Function overloading

        static int sum(int x, int y)
        {
            return x + y;
        }
        static int sum(int x, int y, int z)
        {
            return x + y + z;
        }
        static double sum(int x, double y)
        {
            return x + y;
        }


        #endregion
        static void Main(string[] args)
        {

            #region Poly > Function overloading

            //dynamic result = sum(1, 2);
            //result = sum(1, 2,3);
            //Console.WriteLine(result);

            #endregion


            #region Poly > Operators overloading
            //Complex c1 = new Complex() { Real = 5, Imaginary = 9 };
            //Complex c2 = new Complex() { Real = 3, Imaginary = 2 };
            //Complex c3 = default;


            //c3 = c1 + c2;
            //c3 = c1 + c2 + c3;
            //Console.WriteLine(c3);
            //Complex c4 = ++c3;
            //Console.WriteLine(c4);
            #endregion

      
        }
    }
}
