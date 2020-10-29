using System;

namespace Solve_equation
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
}

