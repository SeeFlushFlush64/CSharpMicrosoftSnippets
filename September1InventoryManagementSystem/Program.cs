using System;
using System.Text;
using Items;
namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            var _foodSection = new FoodSection();
            _foodSection.Run();

        }


    }
    abstract class SectionBase
    {
        public abstract void OpeningPrompt();
    }

    static class InputValidator
    {
       
        /// <summary>
        /// Prompts the user for input and validates whether it is an integer within a specified range.
        /// </summary>
        /// <param name="min">Minimum value of the valid range (inclusive).</param>
        /// <param name="max">Maximum value of the valid range (inclusive).</param>
        /// <returns>Valid integer input from the user.</returns>
        /// 
        public static int GetValidatedInput(int min, int max, SectionBase section)
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
                    Console.Clear();
                    section.OpeningPrompt();
                    Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
                }
            }

            return userInput;
        }
    }

    class FoodSection
    {
        private bool _inputWithinRange = false;
        private int _userInput;
        public FoodSection()
        {

        }
        public void Run()
        {
            OpeningPrompt();
            UserNavigation();
        }
        public static void OpeningPrompt()
        {
            Console.WriteLine("Welcome to Mini-McDo");
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }
        public void UserNavigation()
        {

            while (!_inputWithinRange)
            {
                Console.WriteLine("Please select an option from the following:");
                Console.WriteLine("1. Burgers");
                Console.WriteLine("2. Chicken and Platters");
                Console.WriteLine("3. Drinks and Desserts");
                Console.WriteLine("4. McCafe");
                Console.WriteLine("5. Fries");
                Console.WriteLine("6. Breakfast");
                Console.WriteLine();
                Console.Write("Your input: ");
                if (int.TryParse(Console.ReadLine(), out _userInput))
                {
                    ValidateUserInput();
                }
                else
                {
                    Console.Clear();
                    OpeningPrompt();
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

        }
        public void ValidateUserInput()
        {
            switch (_userInput)
            {
                case 1:
                    _inputWithinRange = true;
                    Console.Clear();

                    var _burgers = new BurgerSection(this, ReturnToPreviousSection);
                    _burgers.OpeningPrompt();
                    _burgers.ShowBurgerMenu(this._myBurgers);
                    break;
                case 2:
                    _inputWithinRange = true;
                    Console.Clear();

                    var _chickenAndPlattersSection = new ChickenAndPlattersSection(this, ReturnToPreviousSection);
                    _chickenAndPlattersSection.OpeningPrompt();
                    _chickenAndPlattersSection.ShowChickenAndPlattersMenu(this._myChickenAndPlatters);
                    break;
                case 3:
                    _inputWithinRange = true;
                    Console.Clear();

                    var _drinksAndDesserts = new DrinksAndDessertsSection(this, ReturnToPreviousSection);
                    _drinksAndDesserts.OpeningPrompt();
                    _drinksAndDesserts.ShowDrinksAndDessertsMenu(this._myDrinksAndDesserts);
                    break;
                case 4:
                    _inputWithinRange = true;
                    Console.Clear();

                    var _mcCafe = new McCafeSection(this, ReturnToPreviousSection);
                    _mcCafe.OpeningPrompt();
                    _mcCafe.ShowMcCafeMenu(this._myMcCafe);
                    break;
                case 5:
                    _inputWithinRange = true;
                    Console.Clear();

                    var _fries = new FriesSection(this, ReturnToPreviousSection);
                    _fries.OpeningPrompt();
                    _fries.ShowFriesMenu(this._myFries);
                    break;
                case 6:
                    _inputWithinRange = true;
                    Console.Clear();

                    var _breakfast = new BreakfastSection(this, ReturnToPreviousSection);
                    _breakfast.OpeningPrompt();
                    _breakfast.ShowBreakfastMenu(this._myBreakfast);
                    break;
                default:
                    Console.Clear();
                    OpeningPrompt();
                    Console.WriteLine("Sorry, your input is out of range :(");
                    break;

            }
        }
        public void ReturnToPreviousSection()
        {
            _inputWithinRange = false;
            Console.Clear();
            OpeningPrompt();
            UserNavigation();
        }



        List<Burgers> _myBurgers = new List<Burgers>
            {
                new Burgers("Big Mac", "A double layer of sear-sizzled, juicy 100% pure beef mingled with special sauce on a sesame seed bun and topped with melty American cheese, crisp lettuce, minced onions, and crisp dill pickles.", 3, 267),
                new Burgers("Burger McDo", "Our all-time classic burger made even better. Now with a beefier patty and a sweeter, tastier sauce.", 2, 140),
                new Burgers("Quarter Pounder with Cheese", "Features a 1//4 lb of 100% fresh beef seasoned with pinch of salt and pepper, and topped with silvered onions, tangy pickles, and two slices of melty cheese on a sesame seed bun.", 3, 267),
                new Burgers("Double Cheeseburger", "The McDonald's Double Cheeseburger features two 100% pure all beef patties seasoned with just a pinch of salt and pepper. It's topped with tangy pickles, chopped onions, ketchup, mustard, and two melty American cheese slices.", 2, 223),
                new Burgers("Cheeseburger", "100% pure beef patty seasoned with a pinch of salt and pepper, topped with a tangy pickle, chopped onions, ketchup, mustard, and a slice of melty American cheese on perfectly toasty buns.", 3, 170),
                new Burgers("McCrispy Chicken Sandwich", "Made of a juicy chicken patty topped with creamy mayo, sandwiched in a soft tasty bun.", 2, 157),
                new Burgers("McChicken Sandwich", "Served on a perfectly toasty bun, with crispy chicken fillet topped with mayonnaise and shredded iceberg lettuce.", 2, 215)
            };
        List<ChickenAndPlatters> _myChickenAndPlatters = new List<ChickenAndPlatters>
            {
                new ChickenAndPlatters("1pc. Chicken McDo with McSpaghetti", "1 piece of crispy, golden brown chicken that's tender and juicy served with the classic spaghetti with ground beef and signature sauce.", 3, 32),
                new ChickenAndPlatters("2pc. Chicken McDo with Rice", "2 pieces of crispy, golden brown chicken that's tender and juicy with steaming rice.", 2, 64),
                new ChickenAndPlatters("1pc. Chicken McDo with Rice", "1 piece of crispy, golden brown chicken that's tender and juicy with steaming rice.", 3, 32),
                new ChickenAndPlatters("McCrispy Chicken Fillet with Rice", "Crispy chicken fillet with steaming rice.", 2, 64),
                new ChickenAndPlatters("6pc. Chicken McNuggets with Rice", "6 golden brown chicken pieces that are juicy on the inside and slightly crispy on the outside which you can dip in BBQ or Sweet 'n' Sour sauce with a classic bunch of crunchy French fries.", 3, 32)
            };
        List<DrinksAndDesserts> _myDrinksAndDesserts = new List<DrinksAndDesserts>
            {
                new DrinksAndDesserts("Coke", "A classic, since 1886. Enjoy it with a meal or on its own as a refreshing drink.", 3, 65),
                new DrinksAndDesserts("Coke Zero", "Zero calories, zero sugar, same great taste Coca-Cola taste. Perfect with your meal, or as a refreshing drink.", 2, 65),
                new DrinksAndDesserts("Coke McFloat", "Refreshingly ice-cold Coca-Cola drink topped with creamy vanilla soft serve ice cream and hot fudge.", 3, 57),
                new DrinksAndDesserts("McFloat with Oreo Cookies", "Chunky, chocolatey Oreo bits blended into rich soft serve ice cream; made more delicious with twice as much Oreo cookie goodness!", 2, 38),
                new DrinksAndDesserts("Hot Fudge Sundae", "Creamy vanilla soft-serve ice cream, smothered with hot fudge topping.", 3, 50),
                new DrinksAndDesserts("Hot Caramel Sundae", "Creamy vanilla soft-serve ice cream, smothered with hot caramel topping.", 2, 50),
                new DrinksAndDesserts("Vanilla Sundae Cone", "Creamy vanilla soft-serve ice cream in a crisp cone, perfect for daily moments of sweetness.", 3, 22),
                new DrinksAndDesserts("Apple Pie", "A pillow-shaped pie that is fried to a golden brown color with a flaky, crisp, and a bubbly crust, natural apple filing, and a slight cinnamon flavor.", 2, 43),
                new DrinksAndDesserts("McCafe Premium Roast Coffee", "Freshly brewed coffee made from 100% Arabica beans with a rich, dark, roasted aroma and a lingering slight bitterness.", 3, 32),
                new DrinksAndDesserts("Orange Juice", "A classic, tangy drink that pairs well with your McDonald's favorites 24/7.", 2, 82)
            };
        List<McCafe> _myMcCafe = new List<McCafe>
            {
                new McCafe("McCafe Americano", "Almost as strong as an expresso, but topped with hot water for a full-bodied flavor.", 3, 135),
                new McCafe("McCafe Capuccino", "Rich espresso topped with hot frothy milk, sprinkled with chocolate powder.", 2, 145),
                new McCafe("McCafe Espresso", "Perk up with a rich, creamy shot 100% pure arabice coffee. Its small in size but really strong.", 3, 95),
                new McCafe("McCafe Cafe Latte", "It's the right mix of strong espresso and velvety steamed milk with a touch of froth.", 2, 145),
                new McCafe("McCafe Macchiato", "A single shot of espresso coffee with a dash of foamed milk. Served in a demitasse cup.", 3, 95),
                new McCafe("McCafe Premium Hot Chocolate", "Rich, premium chocolate drink with hot frothed milk and sprinkled with choco powder.", 2, 145),
                new McCafe("McCafe Iced Mocha", "Cold espresso, coffee mixed with milk and chocolate, topped with whipped cream and drizzled with chocolate syrup.", 3, 155),
                new McCafe("McCafe Iced Americano", "A comforting blend of two parts brewed McCafe espresso and water topped with ice.", 2, 140),
                new McCafe("McCafe Iced Latte", "Cold espresso coffee, fresh milk, and whipped cream equals the cold milky delight.", 3, 145),
                new McCafe("McCafe Iced Double Choco Frappe", "Ice-blended espresso coffee base, milk and chocolate syrup and cookies.", 2, 170),
                new McCafe("McCafe Caramel Frappe", "Blended ice and milk with espresso and caramel syrup. Garnished with whipped cream and thick caramel topping.", 3, 165),
                new McCafe("McCafe Mocha Frappe", "Blended ice and milk with espresso and chocolate syrup. Topped with whipped cream and sprinkled with chocolate powder.", 2, 165),
                new McCafe("McCafe Latte Frappe", "Blended ice and milk with espresso. Topped with whipped cream and sprinkled with chocolate powder.", 3, 160),
                new McCafe("McCafe Strawberry Smoothie", "An ice-blended drink of sweetened strawberry and milk; with real strawberry bits.", 2, 155),
                new McCafe("Blueberry Cheesecake", "Rich and creamy cheesecake, with a graham crust, topped with sweetened blueberries", 3, 170),
                new McCafe("Dark Chocolate Cake", "Moist and decadent dark chocolate cake.", 2, 150),
                new McCafe("Oreo Cheesecake", "Rich and creamy cheesecake with an Oreo crust.", 2, 170),
                new McCafe("Chocolate Chip Cookie", "Chewy and buttery cookie, studded with chocolate chips.", 3, 80)

            };
        List<Fries> _myFries = new List<Fries>
            {
                new Fries("Fries", "Deep fried potato stripes straight cut from whole potatoes, salted, and served hot and crunchy.", 3, 55)
            };
        List<Breakfast> _myBreakfast = new List<Breakfast>
            {
                new Breakfast("Cheesy Eggdesal", "Melty cheese wrapped in a fluffy, folded egg, sandwiched between a soft, toasted pandesal bun.", 2, 103),
                new Breakfast("Sausage McMuffin with Egg", "Freshly toasted English muffin, savory sausage hot off the griddle with a slice of creamy, real American cheese and a freshly cooked Grade A egg.", 1, 115),
                new Breakfast("Sausage Platter with Rice", "Savory sausage hot of the griddle served with hot, steaming garlic rice and light, fluffy scrambled eggs.", 2, 124),
                new Breakfast("Egg McMuffin", "Freshly toasted English muffin, tender and lean Canadian bacon, a slice of creamy, real American cheese and a freshly cooked Grade A egg.", 1, 103),
                new Breakfast("Hash Browns", "Golden brown potato patties that are crisp on the outside and moist on the inside, lightly seasoned and packed with potato goodness.", 2, 37),
                new Breakfast("2pc. Hotcakes with Sausage", "Two golden brown hotcakes with butter and the sweet flavor of maple plus savory sausage hot off the griddle.", 1, 137),
                new Breakfast("3pc. Hotcakes with Sausage", "Three golden brown hotcakes with butter and the sweet flavor of maple.", 1, 350)
            };
    }

    class BurgerSection : SectionBase
    {
        private Action _returnToPreviousMenu;
        public BurgerSection(FoodSection foodSection, Action returnToPreviousMenu)
        {
            _returnToPreviousMenu = returnToPreviousMenu;
        }
        public override void OpeningPrompt()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Burger Section");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }
        public void ShowBurgerMenu(List<Burgers> burgerList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int orderNumber = 1;
            bool alreadyDecremented = false;

            // Define column lengths
            int nameColumnWidth = 45;


            // Header
            string header = "Burgers".PadRight(nameColumnWidth) + "Price";
            Console.WriteLine(header);

            // Generate a dash line that matches the length of the header
            Console.WriteLine("".PadRight(header.Length, '-'));

            Console.WriteLine();
            foreach (Burgers burger in burgerList)
            {
                // Check if orderNumber is 10 or greater and adjust the width accordingly
                if (orderNumber >= 10 && !alreadyDecremented)
                {
                    nameColumnWidth--;  // Decrement only once it reaches two-digit numbers
                    alreadyDecremented = true;
                }
                Console.WriteLine($"{orderNumber}. {burger.Name.PadRight(nameColumnWidth - 3)}₱ {burger.Price}");
                orderNumber++;

            }
            Console.WriteLine("0. Go back to the previous section.");
            Console.WriteLine("");
            Console.WriteLine($"This is the orderNumber: {orderNumber}");

            //We need to subtract 1 from the orderNumber because it is 1 greater than the foodList.Length
            int input = InputValidator.GetValidatedInput(0, orderNumber - 1, this);
            if(input.Equals(0))
            {
                _returnToPreviousMenu();
            }
            else 
            {
                Console.WriteLine($"You have chosen {burgerList[input - 1].Name}.");
            }
        }
    }

    class ChickenAndPlattersSection : SectionBase
    {
        private Action _returnToPreviousMenu;
        public ChickenAndPlattersSection(FoodSection foodSection, Action returnToPreviousMenu)
        {
            _returnToPreviousMenu = returnToPreviousMenu;
        }
        public override void OpeningPrompt()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Chicken And Platters Section");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }
        public void ShowChickenAndPlattersMenu(List<ChickenAndPlatters> chickenAndPlattersList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int orderNumber = 1;
            bool alreadyDecremented = false;

            // Define column lengths
            int nameColumnWidth = 45;


            // Header
            string header = "Chicken And Platters".PadRight(nameColumnWidth) + "Price";
            Console.WriteLine(header);

            // Generate a dash line that matches the length of the header
            Console.WriteLine("".PadRight(header.Length, '-'));

            Console.WriteLine();
            foreach (ChickenAndPlatters chickenAndPlatters in chickenAndPlattersList)
            {
                // Check if orderNumber is 10 or greater and adjust the width accordingly
                if (orderNumber >= 10 && !alreadyDecremented)
                {
                    nameColumnWidth--;  // Decrement only once it reaches two-digit numbers
                    alreadyDecremented = true;
                }
                Console.WriteLine($"{orderNumber}. {chickenAndPlatters.Name.PadRight(nameColumnWidth - 3)}₱ {chickenAndPlatters.Price}");
                orderNumber++;
                
            }
            Console.WriteLine("0. Go back to the previous section.");
            Console.WriteLine("");
            //We need to subtract 1 from the orderNumber because it is 1 greater than the foodList.Length
            int input = InputValidator.GetValidatedInput(0, orderNumber - 1, this);
            if(input.Equals(0))
            {
                _returnToPreviousMenu();
            }
            else 
            {
                Console.WriteLine($"You have chosen {chickenAndPlattersList[input - 1].Name}.");
            }
        }
    }

    class DrinksAndDessertsSection : SectionBase
    {
        private Action _returnToPreviousMenu;
        public DrinksAndDessertsSection(FoodSection foodSection, Action returnToPreviousMenu)
        {
            _returnToPreviousMenu = returnToPreviousMenu;
        }
        public override void OpeningPrompt()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Drinks And Desserts Section");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }
        public void ShowDrinksAndDessertsMenu(List<DrinksAndDesserts> drinksAndDessertsList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int orderNumber = 1;
            bool alreadyDecremented = false;

            // Define column lengths
            int nameColumnWidth = 45;


            // Header
            string header = "Drinks And Desserts".PadRight(nameColumnWidth) + "Price";
            Console.WriteLine(header);

            // Generate a dash line that matches the length of the header
            Console.WriteLine("".PadRight(header.Length, '-'));

            Console.WriteLine();
            foreach (DrinksAndDesserts drinksAndDesserts in drinksAndDessertsList)
            {
                // Check if orderNumber is 10 or greater and adjust the width accordingly
                if (orderNumber >= 10 && !alreadyDecremented)
                {
                    nameColumnWidth--;  // Decrement only once it reaches two-digit numbers
                    alreadyDecremented = true;
                }
                Console.WriteLine($"{orderNumber}. {drinksAndDesserts.Name.PadRight(nameColumnWidth - 3)}₱ {drinksAndDesserts.Price}");
                orderNumber++;
                
            }
            Console.WriteLine("0. Go back to the previous section.");
            Console.WriteLine("");
            //We need to subtract 1 from the orderNumber because it is 1 greater than the foodList.Length
            int input = InputValidator.GetValidatedInput(0, orderNumber - 1, this);
            if(input.Equals(0))
            {
                _returnToPreviousMenu();
            }
            else 
            {
                Console.WriteLine($"You have chosen {drinksAndDessertsList[input - 1].Name}.");
            }
        }
    }

    class McCafeSection : SectionBase
    {
        private Action _returnToPreviousMenu;
        public McCafeSection(FoodSection foodSection, Action returnToPreviousMenu)
        {
            _returnToPreviousMenu = returnToPreviousMenu;
        }
        public override void OpeningPrompt()
        {
            Console.Clear();
            Console.WriteLine("Welcome to McCafe Section");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }
        public void ShowMcCafeMenu(List<McCafe> mcCafeList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int orderNumber = 1;
            bool alreadyIncremented = false;

            // Define the initial column width for the name
            int nameColumnWidth = 45;

            // Header
            string header = "McCafe".PadRight(nameColumnWidth) + "Price";
            Console.WriteLine(header);

            // Generate a dash line that matches the length of the header
            Console.WriteLine("".PadRight(header.Length, '-'));

            Console.WriteLine();

            foreach (McCafe mcCafe in mcCafeList)
            {
                // Check if orderNumber is 10 or greater and adjust the width accordingly
                if (orderNumber >= 10 && !alreadyIncremented)
                {
                    nameColumnWidth--;  // Decrement only once it reaches two-digit numbers
                    alreadyIncremented = true;
                }

                // Display each McCafe item with adjusted padding
                Console.WriteLine($"{orderNumber}. {mcCafe.Name.PadRight(nameColumnWidth)}₱ {mcCafe.Price}");
                orderNumber++;
            }
            Console.WriteLine("0. Go back to the previous section.");
            Console.WriteLine("");
            //We need to subtract 1 from the orderNumber because it is 1 greater than the foodList.Length
            int input = InputValidator.GetValidatedInput(0, orderNumber - 1, this);
            if(input.Equals(0))
            {
                _returnToPreviousMenu();
            }
            else 
            {
                Console.WriteLine($"You have chosen {mcCafeList[input - 1].Name}.");
            }
        }

    }

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
        public void ShowFriesMenu(List<Fries> friesList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int orderNumber = 1;
            bool alreadyDecremented = false;

            // Define column lengths
            int nameColumnWidth = 45;


            // Header
            string header = "Fries".PadRight(nameColumnWidth) + "Price";
            Console.WriteLine(header);

            // Generate a dash line that matches the length of the header
            Console.WriteLine("".PadRight(header.Length, '-'));

            Console.WriteLine();
            foreach (Fries fries in friesList)
            {
                // Check if orderNumber is 10 or greater and adjust the width accordingly
                if (orderNumber >= 10 && !alreadyDecremented)
                {
                    nameColumnWidth--;  // Decrement only once it reaches two-digit numbers
                    alreadyDecremented = true;
                }
                Console.WriteLine($"{orderNumber}. {fries.Name.PadRight(nameColumnWidth - 3)}₱ {fries.Price}");
                orderNumber++;
                
            }
            Console.WriteLine("0. Go back to the previous section.");
            Console.WriteLine("");
            //We need to subtract 1 from the orderNumber because it is 1 greater than the foodList.Length
            int input = InputValidator.GetValidatedInput(0, orderNumber - 1, this);
            if(input.Equals(0))
            {
                _returnToPreviousMenu();
            }
            else 
            {
                Console.WriteLine($"You have chosen {friesList[input - 1].Name}.");
            }
        }
    }

    class BreakfastSection : SectionBase
    {
        private Action _returnToPreviousMenu;
        public BreakfastSection(FoodSection foodSection, Action returnToPreviousMenu)
        {
            _returnToPreviousMenu = returnToPreviousMenu;
        }
        public override void OpeningPrompt()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Breakfast Section");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
        public void ShowBreakfastMenu(List<Breakfast> breakfastList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int orderNumber = 1;

            // Define column lengths
            int nameColumnWidth = 40;


            // Header
            string header = "Breakfast".PadRight(nameColumnWidth) + "Price";
            Console.WriteLine(header);

            // Generate a dash line that matches the length of the header
            Console.WriteLine("".PadRight(header.Length, '-'));

            Console.WriteLine();
            foreach (Breakfast breakfast in breakfastList)
            {
                Console.WriteLine($"{orderNumber}. {breakfast.Name.PadRight(nameColumnWidth - 3)}₱ {breakfast.Price}");
                orderNumber++;
                nameColumnWidth = orderNumber >= 10 ? nameColumnWidth - 1 : nameColumnWidth;
            }
            Console.WriteLine("0. Go back to the previous section.");
            Console.WriteLine("");
            //We need to subtract 1 from the orderNumber because it is 1 greater than the foodList.Length
            int input = InputValidator.GetValidatedInput(0, orderNumber - 1, this);
            if(input.Equals(0))
            {
                _returnToPreviousMenu();
            }
            else 
            {
                Console.WriteLine($"You have chosen {breakfastList[input - 1].Name}.");
            }
        }
    }
}