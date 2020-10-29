using System;

namespace Find_k_and_b
{
    public class FindK

    {
        static public double SolveIndexK(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {

                throw new Exception("x1 can't be equal to x2");
            }
            else
            {
            double k = (y1 - y2) / (x1 - x2);

                return k;
            }

        }
    }
    public class FindB

    {
        static public double SolveIndexB(double x1, double y1, double x2, double y2)
        {
            
            if (x1 == x2)
            {

                throw new Exception("x1 can't be equal to x2");
            }
            else
            {
                double k = (y1 - y2) / (x1 - x2);
            double b = y2 - k * x2;

                return b;
            }

        }
    }
}

