using Sections;
using Items;
namespace InputValidation
{
    public static class InputValidator
    {

        /// <summary>
        /// Prompts the user for input and validates whether it is an integer within a specified range.
        /// </summary>
        /// <param name="min">Minimum value of the valid range (inclusive).</param>
        /// <param name="max">Maximum value of the valid range (inclusive).</param>
        /// <returns>Valid integer input from the user.</returns>
        /// 
        public static int GetValidatedInput(int min, int max, SectionBase section, List<Item> itemList)
        {
            int userInput = 0;
            bool inputValid = false;

            while (!inputValid)
            {
                Console.Write("Your input: ");
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= min && userInput <= max)
                {
                    inputValid = true;
                }
                else
                {
                    string header = $"|Invalid input. Please enter a number between {min} and {max}.|";
                    Console.Clear();
                    section.OpeningPrompt();
                    Console.WriteLine("".PadRight(header.Length, '-'));
                    Console.WriteLine(header);
                    Console.WriteLine("".PadRight(header.Length, '-'));
                    Console.WriteLine();
                    section.ListOfMenu(itemList, 1);

                }
            }

            return userInput;
        }
    }
}