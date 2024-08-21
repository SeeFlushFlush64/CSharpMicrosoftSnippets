using System;
namespace Aug18StringForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Michael";
            foreach(char letter in myString.Reverse())
            {
                Console.Write(letter);
            }
        }
    }
}