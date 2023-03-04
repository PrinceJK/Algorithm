using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int i = 0;
            int temp = 0;
            if (target == 0)
            {
                return 0;
            }

            while (i < nums.Length)
            {
                if (nums[i] - target == 1)
                {
                    return i;
                }
                else if (target == nums[i])
                {
                    return i;
                }
                else if (nums[i] + 1 == target)
                {
                    return i + 1;
                }
                else if (i == nums.Length -1)
                {
                    return i + 1;
                }
                else
                {
                    i++;
                }
            }

            return -1;
        }
        public static int Compress(char[] chars)
        {
            var storage = new List<char>();
            int i = 0;
            int dc = 1;
            int j = 1;
            while (i < chars.Length && j < chars.Length)
            {
                if (chars[i] == chars[j])
                {
                    i++;
                    j++;
                    if (storage.Contains(chars[i]))
                    {
                        continue;
                    }
                    else
                    {
                        storage.Add(chars[i]);
                        dc++;
                    }

                }
                else
                {
                    storage.Add((char)dc);
                    i++;
                    j++;
                    dc = 1;
                }
            }

            chars =  storage.ToArray();
            return storage.Count();
        }
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="Target"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i +1 ; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new ArgumentException("No two sum solution");
        }



        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="Target"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int[] TwoSum1(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                dictionary[nums[i]] = i;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dictionary.ContainsKey(complement) && dictionary[complement] != i)
                {
                    return new[] { i, dictionary[complement] };
                }
            }

            throw new ApplicationException("No two sum solution");
        }

        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        private static int[] TwoSum_Solution3(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];

                if (dictionary.ContainsKey(complement))
                {
                    return new[] { dictionary[complement], i };
                }

                dictionary[nums[i]] = i;
            }

            throw new ApplicationException("No two sum solution");
        }
    }
}
