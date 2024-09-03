using System.Text;
using InventoryManagementSystem;
using Items;
using InputValidation;
namespace Sections
{
    class FriesSection : SectionBase
    {
        private Action _returnToPreviousMenu;
        public FriesSection(FoodSection foodSection, Action returnToPreviousMenu)
        {
            _returnToPreviousMenu = returnToPreviousMenu;
        }
        public override void OpeningPrompt()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Fries Section");
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }
        public override void ListOfMenu(IEnumerable<Item> itemList, int orderNumber)
        {
            // Define column lengths
            int nameColumnWidth = 45;
            int currentOrderNumber = orderNumber;
            Console.OutputEncoding = Encoding.UTF8;

            bool alreadyDecremented = false;

            // Header
            string header = "Burger".PadRight(nameColumnWidth) + "Price";
            Console.WriteLine(header);

            // Generate a dash line that matches the length of the header
            Console.WriteLine("".PadRight(header.Length, '-'));

            Console.WriteLine();

            foreach (var item in itemList)
            {
                // Check if orderNumber is 10 or greater and adjust the width accordingly
                if (currentOrderNumber >= 10 && !alreadyDecremented)
                {
                    nameColumnWidth--;  // Decrement only once it reaches two-digit numbers
                    alreadyDecremented = true;
                }
                Console.WriteLine($"{currentOrderNumber}. {item.Name.PadRight(nameColumnWidth - 3)}₱ {item.Price}");
                currentOrderNumber++;

            }


            Console.WriteLine("0. Go back to the previous section.");
            Console.WriteLine("");
            //We need to subtract 1 from the orderNumber because it is 1 greater than the foodList.Length
            int input = InputValidator.GetValidatedInput(0, currentOrderNumber - 1, this, itemList.ToList());
            if (input.Equals(0))
            {
                _returnToPreviousMenu();
            }
            else
            {
                // Console.WriteLine($"You have chosen {itemList.ElementAt(input - 1).Name}.");
                // Console.WriteLine("Press Enter to continue...");
                // Console.ReadLine();
                // _returnToPreviousMenu(); // This navigates back instead of re-prompting.
                ItemDescription(itemList, input - 1);
            }
        }
        public void ShowFriesMenu(List<Fries> friesList)
        {
            ListOfMenu(friesList, 1);
        }

        public override void ItemDescription(IEnumerable<Item> itemList, int orderNumber)
        {
            Console.Clear();
            Console.WriteLine($"{itemList.ElementAt(orderNumber).Name}\n\nDescription: {itemList.ElementAt(orderNumber).Description}");
        }
    }
}