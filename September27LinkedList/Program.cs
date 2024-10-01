using System;
using System.Collections.Generic;
namespace September27LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            //AddLast() is like queue
            //AddFirst() is like stack
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            // Linear time complexity
            foreach(int num in linkedList)
            {
                Console.WriteLine(num);
            }

            // Linear time complexity
            int[] myNumsArray = linkedList.ToArray();

            // Linear time complexity
            Array.Reverse(myNumsArray);
            System.Console.WriteLine();

            // Linear time complexity
            foreach(int num in myNumsArray)
            {
                System.Console.WriteLine(num);
            }


        }
    }
}