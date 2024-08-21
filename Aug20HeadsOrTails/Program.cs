using System;
namespace HeadsOrTails
{
    class Program
    {
        static string GenerateResult(int outcomes)
        {
            Random random = new Random();
            return random.Next(0, 2) == 0 ? "Heads" : "Tails";
            // double generatedValue = Math.Floor(random.NextDouble() * outcomes);
            // return generatedValue == 0 ? "Heads"  : "Tails";

        }
        static void Main(string[] args)
        {
            int outcomes = 2;
            Console.WriteLine(GenerateResult(outcomes));
        }
    }
    
}