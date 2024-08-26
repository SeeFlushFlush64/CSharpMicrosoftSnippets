using System;
namespace SelectYourRole
{
    class Program
    {

        static void Main(string[] args)
        {
            OpeningPrompt();
            GetUserRole();
        }
        static void OpeningPrompt()
        {
            Console.WriteLine("Select your role:\n> Administrator\n> Manager\n> User");
        }
        static void WarningPrompt(string userRole)
        {
            Console.WriteLine($"The role name that you entered, \"{userRole}\" is not valid.");
        }
        static void SuccessPrompt(string userRole)
        {
            Console.WriteLine($"Your input value ({userRole}) has been accepted.");
        }
        static bool IsUserInputEmpty(string userRole)
        {
            return string.IsNullOrEmpty(userRole);
        }
        static string GetUserRole()
        {
            string userRole = "";
            string rawUserInput = "";
            bool roleMatched = false;
            
            do
            {
                Console.Write("Your role: ");
                rawUserInput = Console.ReadLine().Trim();
                string lowerCasedParts = rawUserInput[1..].ToLower();
                string upperCasedPart = Convert.ToString(rawUserInput[0]).ToUpper();
                userRole = $"{upperCasedPart}{lowerCasedParts}";
                switch (userRole)
                {
                    case "Administrator":
                        roleMatched = !roleMatched;
                        break;
                    case "Manager":
                        roleMatched = !roleMatched;
                        break;
                    case "User":
                        roleMatched = !roleMatched;
                        break;
                    default:
                        WarningPrompt(rawUserInput);
                        break;
                }
            } while (!roleMatched || IsUserInputEmpty(userRole));

            SuccessPrompt(userRole);

            return userRole;
        }
    }
}