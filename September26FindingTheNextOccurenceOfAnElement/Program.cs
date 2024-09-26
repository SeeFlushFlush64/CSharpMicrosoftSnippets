using System;

namespace September26FindingTheNextOccurenceOfAnElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 5 };
            int target = 2;
            int targetIndex = 0;
            int firstOccurence = Array.IndexOf(arr, target);
            targetIndex = Array.IndexOf(arr, target, firstOccurence + 1);
            System.Console.WriteLine($"The first occurence of number 2 is at index {firstOccurence}");
            System.Console.WriteLine($"The location of number 2 is at index {targetIndex}");
        }
    }
}