using System;

namespace Swap_of_Variables
{
    public class SwapTheVariables
    {
        static void SwapTheVariables1(int a, int b)
        {
            Console.WriteLine("Initial A= " + a);
            Console.WriteLine("Initial B= " + b);
            int a1 = a;
            int b1 = b;
            b = a1;
            a = b1;
            Console.WriteLine("Swap A= " + a);
            Console.WriteLine("Swap B= " + b);
        }
    }
}
