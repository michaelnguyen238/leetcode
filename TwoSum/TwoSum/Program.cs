using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testCase = new int[4] { -3,4,3,90 };
            int target = 0;

            Console.WriteLine("Test case: " + PrintArray(testCase) + ", target = " + target);

            int[] results = TwoSum(testCase, target);

            Console.WriteLine("Result: " + PrintArray(results));
            Console.WriteLine("Expected Result: [0,2]");

        }
        static int[] TwoSum(int[] nums, int target)
        {
            int[] results = new int[2];
            int remainder;

            // Dictionary where Key = nums Value, Value = nums Index
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // Initialize first dictionary entry using 0 for nums Index
            dict.Add(nums[0], 0);

            for (int i = 1; i < nums.Length; i++)
            {
                remainder = target - nums[i];

                if (dict.ContainsKey(remainder))
                {
                    dict.TryGetValue(remainder, out results[0]);
                    results[1] = i;
                    return results;
                }
                else
                {
                    dict.Add(nums[i],i);
                }
            }
            return results;
        }
        static string PrintArray(int[] arr)
        {
            string result = "[";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                result += arr[i] + ",";
            }
            result += arr[arr.Length - 1] + "]";

            return result;
        }
    }
}
