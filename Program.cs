/*
 Author: Qian Wang, You Zhou, Shitao Liao
 Date: 09/18/202
 Project: Assignment 2
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;

namespace Assignment2_Fall2020_Group5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            Console.WriteLine("Question 1");
            int n = 7;
            Console.WriteLine("Pattern printed with O(n^2) time complexity: ");
            PrintPatternAnyComplexity(n);
            Console.WriteLine();
            Console.WriteLine("Pattern printed with O(n) time complexity: ");
            PrintPatternLinearComplexity(n);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            // Question 2
            Console.WriteLine("Question 2");
            int[] array1 = new int[] { 1, 3, 5, 4, 7 };
            int result = LongestSubSeq(array1);
            Console.WriteLine("The longest continuous subsequece in array [" + string.Join(",", array1) + "] is: "  + result);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            // Question 3
            Console.WriteLine("Question 3");
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 5};
            Console.WriteLine("The array to be partitioned is: ["+ string.Join(",", array2) + "]");
            PrintTwoParts(array2);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            // Question 4
            Console.WriteLine("Question 4");
            int[] array3 = new int[] { -4, -1, 0, 3, 10 };
            Console.WriteLine("The original array is: [" + string.Join(",", array3) + "]");
            int[] result2 = SortedSquares(array3);
            Console.WriteLine("The array of sorted square values is: [" + string.Join(",", result2) +"]");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            // Question 5
            Console.WriteLine("Question 5");
            int[] nums1 = { 3, 6, 2 };
            int[] nums2 = { 6, 3, 6, 7, 3 };
            int[] intersect1 = Intersect(nums1, nums2);
            Console.WriteLine("array 1 is: [" + string.Join(",", nums1) +"]");
            Console.WriteLine("array 2 is: [" + string.Join(",", nums2) +"]");
            Console.WriteLine("The interected elements are: [" + string.Join(",", intersect1) +"]");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            // Question 6
            Console.WriteLine("Question 6");
            int[] arr = new int[] { 1, 2, 2, 1, 1, 3 };
            Console.WriteLine("The array is: [" + string.Join(",", arr) +"]");
            Console.WriteLine("The number of occurrences of each value in the array is unique? "+ UniqueOccurrences(arr));
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            // Question 7
            Console.WriteLine("Question 7");
            int[] numbers = { 0, 1, 3, 50, 75 };
            int lower = 0;
            int upper = 99;
            Console.WriteLine("The array is: [" + string.Join(",", numbers) + "], lower bound is " + lower + " and upper bound is " + upper);
            List<String> ResultList = Ranges(numbers, lower, upper);
            Console.WriteLine("The missing ranges are: [" + string.Join(",", ResultList) + "]");
            Console.WriteLine();
            int[] numbers2 = { 0, 1, 2, 3, 4 };
            int lower2 = 0;
            int upper2 = 4;
            Console.WriteLine("The array is: [" + string.Join(",", numbers2) + "], lower bound is " + lower2 + " and upper bound is " + upper2);
            List<String> ResultList2 = Ranges(numbers2, lower2, upper2);
            Console.WriteLine("The missing ranges are: [" + string.Join(",", ResultList2) + "]");
            Console.WriteLine();
            int[] numbers3 = {};
            int lower3 = 0;
            int upper3 = 4;
            Console.WriteLine("The array is: [" + string.Join(",", numbers3) + "], lower bound is " + lower3 + " and upper bound is " + upper3);
            List<String> ResultList3 = Ranges(numbers3, lower3, upper3);
            Console.WriteLine("The missing ranges are: [" + string.Join(",", ResultList3) + "]");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            // Question 8
            Console.WriteLine("Question 8");
            string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            Console.WriteLine("The names array is [" + string.Join(",", names) + "]");
            string[] namesResult = UniqFolderNames(names);
            Console.WriteLine("The unique folder names array is [" + string.Join(",", namesResult) + "]");

        }

        // Method 1: Print pattern using any time complexity
        public static void PrintPatternAnyComplexity(int n)
        {
            try
            {
                // Outer for loop to print stars on each line
                for (int i = 1; i <= n; i++)  
                {
                    // Inner for loop to print number of stars each line
                    for (int j = 1; j <= i; j++) 
                    {
                        Console.Write("* ");  // Display number of starts
                    }
                    Console.WriteLine();  
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        // Method 2: Print pattern with O(n) time complexity
        public static void PrintPatternLinearComplexity(int n)
        {
            try
            {
                // Initialize an empty string
                string star = "";   
                
                // Append one star to the string each iteration
                for (int i = 1; i <= n; i++)
                {
                    star += "* ";   // Add a star to the string
                    Console.WriteLine(star);   // Print the current star
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        
        // Method to find the longest subsequence
        public static int LongestSubSeq(int[] nums)
        {
            try
            {
                // Corner case when there is no element in the array and the array is null
                if (nums.Length == 0 || nums == null)
                {
                    return 0;
                }

                // Initialize both the current length and max length with 1
                int cur = 1;  
                int max_len = 1;

                // For loop to iterate through the 2nd element to the last
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] > nums[i - 1])
                    {
                        cur++;  // Incement the current length by 1 if the current value is greater than previous one
                        max_len = Math.Max(max_len, cur);  // Update the maximum length with the larger value between curren length and max length
                    }
                    else
                    {
                        cur = 1;  // Reset the current length to 1 if the condition not met
                    }
                }
                return max_len;
            }
            catch (Exception)
            {
                throw;
            }
            //return 0;
        }
        // Method to partition an array into two subarray with equal sum
        public static void PrintTwoParts(int[] array2)
        {
            try
            {
                // case when the sum of the array is an odd number or it's an empty array, jump out the method
                if (array2.Sum() % 2 != 0 || array2.Length == 0)
                {
                    Console.WriteLine("False");
                    return;
                }

                // Calculate half sum of all elements in the array
                int half_sum = array2.Sum() / 2;

                // Case when the first or the last element is greater than the half of total sum
                if (array2[0] > half_sum || array2[^1] > half_sum)
                {
                    Console.WriteLine("False");
                    return;
                }

                
                int sum_so_far = array2[0];  // Variable to hold cumulative sum before ith element
                for (int i = 1; i < array2.Length; i++)
                {
                    if (sum_so_far == half_sum)
                    {
                        Console.WriteLine("The left subarray is: [" + string.Join(",", array2[0..i]) + "]");  // The left subarray contains the first element to the i -1 element
                        Console.WriteLine("The right subarray is: [" + string.Join(",", array2[i..^0]) + "]");  // The right subarray contains the ith element to the last one in array2
                        break;
                    }  // If the condition is met, print the left and right subarray
                    else
                    {
                        sum_so_far += array2[i];  // add ith element to the sum
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        // Method to sort the square of element in an array
        public static int[] SortedSquares(int[] A)
        {
            try
            {
                // Corner case when A is null or empty
                if (A == null || A.Length == 0)
                {
                    return null;
                }

                // Initialize a new array with the size of array A
                int[] result = new int[A.Length];

                // Initialize two pointers point to the first and last element in A
                int left = 0;
                int right = A.Length - 1;

                // Iterate A backwards
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    // Compare the absolute value of left and right elements in A: because there could be negative elements in the array and their square will get greater than small non negative ones
                    if (Math.Abs(A[left]) > Math.Abs(A[right]))  
                    {
                        // If the absolute value of left element is greater, append the square value to the result array backwards
                        result[i] = A[left] * A[left];  
                        left++;   // move the left pointer one step to the right
                    }
                    else
                    {
                        // If the absolute value of right element is greater, append the square value to the result array backwards
                        result[i] = A[right] * A[right];
                        right--; // Move the left pointer one step to the left
                    }
                }
                return result;

            }
            catch (Exception)
            {
                throw;
            }
            //return null;
        }

        // Method to get the intersection of two arrays
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            try
            {
                // Initialize a dictionary to store key value pairs 
                var dict = new Dictionary<int, int>();

                // Store each unique element as the keys and their counts as values in the dictionary
                foreach (int i in nums1)
                {
                    if (dict.ContainsKey(i))
                    {
                        dict[i] += 1;
                    }
                    else
                    {
                        dict[i] = 1;
                    }
                }

                // Initialize a list to hold the intersected elements: since we don't know the true number of the intersected elements, list is better than array which doesn't need to specify size
                List<int> result = new List<int>();
                
                // Iterate through num2 to find whether there is matched element in dict
                foreach (int i in nums2)
                {
                    if (dict.ContainsKey(i))
                    {
                        result.Add(i);   // Append the matched element to the result list
                        dict[i] -= 1;    // decrease the value of that matched key
                        // Check whether the value of that key is equal to 0
                        if (dict[i] == 0)
                        {
                            dict.Remove(i);  // Remove item from dict if it's true
                        }
                    }
                }
                return result.ToArray();  // convert to array and return
            }
            catch (Exception)
            {
                throw;
            }
            //return new int[] { };
        }

        // Method
        public static bool UniqueOccurrences(int[] arr)
        {
            try
            {
                // Corner case when there are no more than 1 element in the array, the occurence will be unique
                if (arr.Length <= 1)
                {
                    return true;
                }

                // Initialize dictionary and hashset
                var hash = new HashSet<int>();  // It is like set() in Python, contains no duplicates
                var dict = new Dictionary<int, int>();

                // Store each element and its occurences in the array in the dictionary
                foreach (var t in arr)
                {
                    if (dict.ContainsKey(t))
                    {
                        dict[t]++;   // If a key already exists, increment its value by 1
                    }
                    else
                    {
                        dict[t] = 1;  // If a key does not exist, add it and set the value to 1
                    }
                }

                // Add the each value in the dictionary to the hashset
                foreach (var k in dict)
                {
                    if (hash.Contains(k.Value))
                    {
                        return false;   // Since hashset cannot contain duplicates, if a value already exists, return false
                    }
                    else
                    {
                        hash.Add(k.Value); // Otherwise, add the value to the hashset
                    }
                }
                return true;
                // Time: O(n) + O(n) => O(n)   Space: O(n)
            }
            catch (Exception)
            {
                throw;
            }
            //return default;
        }

        
        // Method to get the missing range 
        public static List<String> Ranges(int[] numbers, int lower, int upper)
        {
            try
            {
                // Initialize a list to hold all the possible missing ranges
                List<String> result = new List<String>();

                
                long l = Convert.ToInt64(lower); // Prevent overflow
                long u = Convert.ToInt64(upper); // Prevent overflow
                int n = numbers.Length;

                foreach (int num in numbers)
                {
                    if (l == num)
                    {
                        l++;   // Increment the lower bound value by one
                    }
                    else if (l < num)  // Case when lower bound is less than current number
                    {
                        if (l + 1 == num)  // Case when lower bound is exact the previous number of the current number
                        {
                            result.Add(l.ToString());  // Add current lower bound value to the result
                        }
                        else  // case when the missing numbers are more than one
                        {
                            result.Add(l + "->" + (num - 1));  // Add the range from the current lower bound to the previous number of the current number
                        }

                        l = Convert.ToInt64(num) + 1; // Update the lower bound value with current value + 1
                    }
                }

                // Handle case when after execute above code, the upper bound is still greater than the largest number in the array
                if (l == u)  // Case when current lower bound equal upper bound. Note: the current lower bound value should be the largest number in the array + 1
                {
                    result.Add(l.ToString()); 
                }
                else if (l < u) // Case when there are more than 1 number in the left range.
                {
                    result.Add(l + "->" + u);
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            //return default;
        }

        

        // Method 
        public static string[] UniqFolderNames(string[] names)
        {
            try
            {
                // Corner case
                if (names == null || names.Length == 0)
                {
                    return null;
                }

                // Initialize a dictionary and a string array to hold the output
                Dictionary<string, int> map = new Dictionary<string, int>();
                String[] result = new string[names.Length];
                int i = 0; // index to result

                foreach (var name in names)
                {
                    if (map.ContainsKey(name))
                    {
                        int k = map[name];  // If the name is in the dictionary, assign the corresponding value to k
                        string next = string.Format("{0}({1})", name, k); // Assign the generated folder name to next variable

                        while (map.ContainsKey(next))  // Check whether the generated folder name with suffix exists in the dictionary
                        {
                            k++;    // If there are duplcates, increment the suffix 
                            next = string.Format("{0}({1})", name, k);  // Assign the new name with increased suffix to next and check again
                        }
                        map.Add(next, 1);  // While there is no duplicates, add the generated unique folder name to the dictionary
                        map[name] = k + 1; // Increase the value of that key
                        result[i] = next;  // Add the folder name to result
                    }
                    else
                    {
                        map.Add(name, 1);  // Add the key value pair to the dictionary if there is no such key
                        result[i] = name;  // Add the name to result
                    }
                    i++;
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            //return default;
        }
    }
}

