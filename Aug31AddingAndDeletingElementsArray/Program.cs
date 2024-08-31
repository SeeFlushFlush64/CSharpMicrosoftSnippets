using System;
namespace AddingAngDeletingElementsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = 
            {
                "Michael", "Rhey", "Owen"
            };

            //Printing of firstNames elements
            Console.WriteLine("Original First Names");
            foreach (string firstName in firstNames)
            {
                Console.WriteLine(firstName);
            }

            //Array to List conversion, using of Remove() to remove an element "Rhey"
            List<string> listOfNames = new List<string>(firstNames);
            listOfNames.Remove("Rhey");

            //List to Array, "Michael", "Owen" are the elements only of the list will be assigned to newNames array
            string[] newNames = listOfNames.ToArray();

            //Use of spread operator, "Michael", "Owen", "Daniell", "Jake"
            string[] updatedFirstNames = 
            [
                ..newNames, "Daniell", "Jake"

            ];

            Console.WriteLine("Updated First Names");
            foreach (string updated in updatedFirstNames)
            {
                Console.WriteLine(updated);
            }
        }
    }
}