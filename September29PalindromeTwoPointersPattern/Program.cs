//I have learned that when checking whether a string is a palindrome or not, we don't need to make a new array
//we could make use of the two pointers pattern
using System;
namespace September29PalindromeTwoPointersPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "ahha";
            // System.Console.WriteLine(myString.Length / 2);
            System.Console.WriteLine(IsPalindrome(myString));

        }
        private static bool IsPalindrome(string str)
        {
            //"racecar" 7 letters = 3
            //"ahha" 4 letters = 2
    
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}