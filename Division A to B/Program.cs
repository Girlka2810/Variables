using System;
using SimpleDivision;
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
            Console.WriteLine("Result: " + x);
        }
    }
}
