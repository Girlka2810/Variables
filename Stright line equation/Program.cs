using System;
using Variables_Math;
namespace Stright_line_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            Console.WriteLine("Enter x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A (" + x1 + "," + y1 + ")");
            Console.WriteLine("B (" + x2 + "," + y2 + ")");
            double k = FindKAndB.SolveIndexK(x1,y1,x2,y2);
            double b = FindKAndB.SolveIndexB(x1, y1, x2, y2);
            Console.Write("Stright line equation: y=");
            Console.Write(k + "*x + " + b);
        }
    }
}
