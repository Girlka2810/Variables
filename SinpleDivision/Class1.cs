using System;

namespace SimpleDivision
{
    public class Division
    {
        static public double SimpleDivision(double a, double b)
        {
            if (b == 0)
            {

                throw new Exception("B can't be equal to 0");
            }
            else
            {
                double c = a/b;

                return c;
            }
        }
    }
}
