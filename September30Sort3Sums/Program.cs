// using System;
// namespace September30Sort3Sums
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // int[] nums = [-1,0,1,2,-1,-4];
//             int[] nums = [0, 0, 0];
//             // -4, -1, -1, 0, 1, 2
//             IList<IList<int>> myTriplets = ThreeSums(nums);
//             foreach (var item in myTriplets)
//             {
//                 Console.WriteLine("[" + string.Join(",", item) + "]");
//             }
//         }
//         private static IList<IList<int>> ThreeSums(int[] nums)
//         {
//             List<IList<int>> myTriplets = new List<IList<int>>();
//             Array.Sort(nums);
//             int a = 0;
//             for(int i = a; i < nums.Length - 2; i++)
//             {
//                 int low = i + 1;
//                 int high = nums.Length - 1;
//                 //The idea is that, the high will move on the right/end of the array
//                 // if the sum of the i, low and high is lesser than 0, then we will immediately increment the i and j
//                 //there is no point of moving the high close to low since, it will result to a much lower sum
//                 while (low < high)
//                 {
//                     int sum = nums[i] + nums[low] + nums[high];
//                     if (sum < 0)
//                     {
//                         low++;
//                     }
//                     else if (sum > 0)
//                     {
//                         high--;
//                     }
//                     else if (sum == 0)
//                     {
//                         myTriplets.Add(new List<int> {nums[i], nums[low], nums[high]});
//                     }
//                     else if (i == nums.Length - 2)
//                     {
//                         return myTriplets;
//                     }
//                 }

//             }
//             // for(int i = a; i <= nums.Length / 2; i++)
//             // {
//             //     int j = nums.Length - 1;
//             //     int k = nums.Length - 2;
//             //     while(k != i)
//             //     {
//             //         if (nums[i] + nums[k] + nums[j] == 0)
//             //         {
//             //             myTriplets.Add(new List<int> {nums[i], nums[k], nums[j]});
//             //         }
//             //         if (k == 1 && i == nums.Length / 2)
//             //         {
//             //             return myTriplets;
//             //         }
                    
//             //         j--;
//             //         k--;
//             //     }
                
//             // }
//             return new List<IList<int>>();
//         }
//     }
// }

using System;
using System.Collections.Generic;

namespace September30Sort3Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> myTriplets = ThreeSums(nums);

            // Print the triplets
            foreach (var item in myTriplets)
            {
                Console.WriteLine("[" + string.Join(",", item) + "]");
            }
        }

        private static IList<IList<int>> ThreeSums(int[] nums)
        {
            List<IList<int>> myTriplets = new List<IList<int>>();


            Array.Sort(nums);

            for (int i = 0; i <= nums.Length - 3; i++)
            {

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int low = i + 1;
                int high = nums.Length - 1;

                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];

                    if (sum == 0)
                    {
                        //- 4, -1, -1, 0, 1, 2
                        myTriplets.Add(new List<int> { nums[i], nums[low], nums[high] });


                        while (low < high && nums[low] == nums[low + 1]) low++;
                        while (low < high && nums[high] == nums[high - 1]) high--;

                        low++;
                        high--;
                    }
                    else if (sum < 0)
                    {
           
                        low++;
                    }
                    else
                    {
                   
                        high--;
                    }
                }
            }

            return myTriplets;
        }
    }
}
