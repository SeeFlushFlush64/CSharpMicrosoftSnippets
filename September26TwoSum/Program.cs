using System;
namespace September26TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNum = {2, 3, 1};
            int targetSum = 3;
            List<int> addendsIndex = new List<int>();
            bool addends = false;
            for (int i = 0; i < myNum.Length; i++)
            {
                for (int j = i + 1; j < myNum.Length; j++)
                {
                    if (myNum[i] + myNum[j] == targetSum)
                    {
                        addendsIndex.Add(myNum[i]);
                        addendsIndex.Add(myNum[j]);
                    }
                }
            }
            foreach(int myIndex in addendsIndex)
            {
                System.Console.WriteLine(myIndex);
            }
        }
    }
}