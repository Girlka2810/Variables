using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAnswer(3, 5);
            GetAnswer(5,10);
            //GetAnswer(10, 3);
        }
        static void GetAnswer(int a,int b)
        {
            if (b>a)
            {

            int c = (5 * a + b * b) / (b - a);
                Console.WriteLine("Result: " + c);
                //return c;
            }
            else
            {
                throw new Exception("B can't be less than A");
            }

        }
    }
}
