using System;
namespace ValidateIntegerInput
{
    class Program
    {

        static void Main(string[] args)
        {
            UserPrompt();
            GetIntegerInput();
        }
        static void UserPrompt()
        {
            Console.Write("Please enter a number between 5 and 10: ");
        }
        static void WarningPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, you entered an invalid input, please try again");
        }
        static void DisplayValidInput(int numericValue)
        {
            Console.WriteLine($"{numericValue} is indeed between 5 and 10");
        }
        static void GetIntegerInput()
        {
            int numericValue = 0;
            bool validNumber = false;
            bool numberWithinRange = false;
            do
            {
                validNumber = int.TryParse(Console.ReadLine(), out numericValue);
                numberWithinRange = numericValue > 5 && numericValue < 10;
                if (validNumber && numberWithinRange)
                {
                    break;
                }
                else 
                {
                    WarningPrompt();
                    UserPrompt();
                }
            } while (!validNumber || !numberWithinRange);
            DisplayValidInput(numericValue);
        }
    }
}