using System;

namespace Find_X
{
    public class FindX

    {
        static public double SolveSimpleEquation(double a, double b, double c)
        {
            if (a == 0)
            {

                throw new Exception("A can't be equal to 0");
            }
            else
            {
                double x = (c-b)/a;

                return x;
            }

        }
    }
}
