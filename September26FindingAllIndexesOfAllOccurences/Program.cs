using System;

namespace September26FindingAllIndexesOfAllOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 2 };
            int target = 2;
            int targetIndex = 0;
            int firstOccurence = 0;
            bool foundOne = false;
            
            do 
            {
                if (!foundOne)
                {
                    firstOccurence = Array.IndexOf(arr, target);
                    System.Console.WriteLine($"The first occurence of number 2 is at index {firstOccurence}");
                    foundOne = !foundOne;
                }
                targetIndex = Array.IndexOf(arr, target, firstOccurence + 1);
                if (targetIndex == -1)
                {
                    break;
                }
                System.Console.WriteLine($"The next occurence of number 2 is at index {targetIndex}");
                firstOccurence = targetIndex;
            } while (targetIndex != -1);
        }
    }
}