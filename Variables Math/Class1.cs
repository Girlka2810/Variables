using System;

namespace Variables_Math
{

    public class SolveEquation
    {
        static public double SimpleFraction(double a, double b)
        {
            if (b == a)
            {
                throw new Exception("B can't be equal to A");
            }
            else
            {
                double c = (5 * a + b * b) / (b - a);
                return c;
            }
        }
    }
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
                double c = a / b;

                return c;
            }
        }
        static public double FindRemainder(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("B can't be equal to 0");
            }
            else
            {
                double c = a % b;
                return c;
            }
        }
    }
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
                double x = (c - b) / a;
                return x;
            }
        }
    }
    public class FindKAndB
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
