using System;
namespace September303Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] nums = [-1,0,1,2,-1,-4];
            int[] nums = [0, 0, 0, 0];
            IList<IList<int>> myElements = ThreeSum(nums);
            foreach (List<int> num in myElements)
            {
                // foreach (int element in num)
                // {
                //     System.Console.WriteLine(element);
                // }
                
                System.Console.WriteLine($"[{string.Join(", ", num)}]");
                
            }
            // foreach (List<int> numList in myElements)
            // {
            //     // Use string.Join to print the list as a comma-separated string
            //     Console.WriteLine($"[{string.Join(", ", numList)}]");
            // }
        }
        public static IList<IList<int>> ThreeSum(int[] nums) {
            int a = 0;
            HashSet<IList<int>> randomHash = new HashSet<IList<int>>();
            List<IList<int>> zeroSum = new List<IList<int>>();
            for (int i = a; i < nums.Length / 2; i++)
            {
                int j = nums.Length - 1;
                int k = nums.Length - 2;
                while (k != 0)
                {
                    if (k == 0)
                    {
                        break;
                    }
                    
                    if (nums[i] + nums[k] + nums[j] == 0)
                    {
                        randomHash.Add(new List<int> {nums[i], nums[k], nums[j]});
                    }
                    if (i == (nums.Length / 2) - 1)
                    {
                        return new List<IList<int>>(randomHash);
                        // return zeroSum;
                    }
                    j--;
                    k--;
                }
                
            }
            return new List<IList<int>>();
        }
    }
}