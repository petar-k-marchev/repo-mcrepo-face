using System;

namespace SafeMathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrintTest1();
        }

        private static void PrintTest1()
        {
            Console.WriteLine("1 + 2 = {0}", 1 + 2);
            Console.WriteLine("safe 1 + 2 = {0}", SafeMath.SafeSum(1, 2));
            Console.WriteLine("1 + double.NaN = {0}", 1 + double.NaN);
            Console.WriteLine("safe 1 + double.NaN = {0}", SafeMath.SafeSum(1, double.NaN));
            Console.WriteLine("safe double.NaN + double.NaN = {0}", SafeMath.SafeSum(double.NaN, double.NaN));
        }
    }
}
