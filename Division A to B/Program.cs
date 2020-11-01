using System;
using Variables_Math;
namespace Division_A_to_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter A =");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter B =");
            double b = Convert.ToInt32(Console.ReadLine());
            double x = Division.SimpleDivision(a, b);
            double x1 = Division.FindRemainder(a, b);
            Console.WriteLine("Result: " + x+ " Remaider: " + x1);
        }
    }
}
