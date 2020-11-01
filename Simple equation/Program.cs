using System;
using Variables_Math;

namespace Simple_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter A =");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter B =");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter C =");
            double c = Convert.ToInt32(Console.ReadLine());
            double x = FindX.SolveSimpleEquation (a, b,c);
            Console.WriteLine("X equal " + x);
        }
    }
}
