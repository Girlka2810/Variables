﻿using System;
using Variables_Math;
namespace SimpleFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter A =");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter B =");
            double b = Convert.ToInt32(Console.ReadLine());
            double x = VariablesMath.SimpleFraction(a, b);
            Console.WriteLine("X equal " + x);
        }
    }
}
