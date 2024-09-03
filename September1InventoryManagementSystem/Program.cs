using System;
using System.Text;
using Items;
using Sections;
using MyTextFormatter;
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
}