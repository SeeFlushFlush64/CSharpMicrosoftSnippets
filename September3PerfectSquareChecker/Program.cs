using System;
namespace PerfectSquareChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math.Sqrt() returns a NaN if the argument supplied is a negative number
            //Also, it will return NaN if the argument supplied is not a number too 
            Console.WriteLine(IsPerfectNumber(-1));
        }
        static bool IsPerfectNumber(int number)
        {
            //Note: taking the modulo of the Math.Sqrt() is a way for us to know whether it has a decimal or not
            //Remember: if you are going to divide a whole number by 1, its remainder will always be 0
            //In our case if Math.Sqrt() has a decimal, dividing it by 1 will result to that decimal after the integer part
            //Hence, not equal to 0

            //How to output NaN (inputs for Math.Sqrt())
            // int negatives = -1;
            // double num = 0.0 / 0.0;
            // double infinites = double.PositiveInfinity * 0;

            return Math.Sqrt(number) % 1 == 0;
        }
    }
}