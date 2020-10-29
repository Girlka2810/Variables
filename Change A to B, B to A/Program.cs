using System;

namespace Change_A_to_B__B_to_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap the contents of variables A and B in places.");
            SwapTheVariables(4, 5);
            SwapTheVariables(100,43);
        }
        static void SwapTheVariables (int a, int b)
        {
            Console.WriteLine("Initial A= " + a);
            Console.WriteLine("Initial B= " + b);
            int a1 = a;
            int b1 = b;
            b = a1;
            a = b1;
            Console.WriteLine ("Swap A= "+a);
            Console.WriteLine("Swap B= "+b);
        }
    }
}
