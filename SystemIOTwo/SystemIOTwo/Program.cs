using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SystemIOTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ChallengeOne();
            //ChallengeTwo();
            //ChallengeThree();
            ChallengeFour();
        }

        #region ChallengeOne
        /// <summary>
        /// A method that asks the user for 3 numbers.
        /// Return the product of these 3 numbers multiplied together.
        /// If the user puts in less than 3 numbers, return 0.
        /// If the user puts in more than 3 numbers, only multiply the first 3.
        /// If the number is not a number, default that value to 1.
        /// </summary>
        public static void ChallengeOne()
        {
            Console.Write("Please enter 3 numbers (eg. 4 8 15): ");
            string input = Console.ReadLine();
            Console.WriteLine("The product of these 3 numbers is: {0}", GetProduct(input));
            Console.WriteLine();
        }

        /// <summary>
        /// A method that parses a string input by the space and returns the product
        /// </summary>
        /// <param name="input">The 3 numbers entered by the user sepreated by spaces</param>
        /// <returns>The product of the 3 numbers entered</returns>
        public static int GetProduct(string input)
        {
            string[] nums = input.Split(' ');

            if (nums.Length < 3)
                return 0;

            int product = 1;

            for (int i = 0; i < 3; i++)
            {
                int num;

                if (!int.TryParse(nums[i], out num))
                    product *= 1;
                else
                    product *= num;
            }

            return product;
        }
        #endregion

        #region ChallengeTwo
        /// <summary>
        /// A method that asks the user to enter a number between 2-10.
        /// Then, prompt the user that number of times for random numbers.
        /// After the user has inputted all of the numbers, find the average of all the numbers inputted.
        /// </summary>
        public static void ChallengeTwo()
        {
            Console.Write("Please enter a number between 2-10: ");
            string input = Console.ReadLine();

            int count;

            while (!int.TryParse(input, out count) || count < 2 || 10 < count)
            {
                Console.Write("Please enter a number between 2-10: ");
                input = Console.ReadLine();
            }

            int[] arr = new int[count];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{ i + 1 } of {count} - Enter a number: ");
                input = Console.ReadLine();

                int num;

                while (!int.TryParse(input, out num) || num < 0)
                {
                    Console.WriteLine($"{ i + 1 } of {count} - Enter a number: ");
                    input = Console.ReadLine();
                }

                arr[i] = num;
            }

            Console.WriteLine($"The average of these {count} numbers is: {GetAverage(arr, count)}");
            Console.WriteLine();
        }

        /// <summary>
        /// A method iterates through an int array and return the average of the numbers in the index
        /// </summary>
        /// <param name="arr">An int array containing the list of random numbers entered by the user</param>
        /// <param name="count">A number chosen by the user</param>
        /// <returns>The average of all the numbers from the int array</returns>
        public static int GetAverage(int[] arr, int count)
        {
            int sum = 0;

            for (int i = 0; i < count; i++)
                sum += arr[i];

            return sum / count;
        }
        #endregion

        #region ChallengeThree
        // source: https://www.w3resource.com/csharp-exercises/for-loop/csharp-for-loop-exercise-31.php
        /// <summary>
        /// A method that outputs a diamon like pattern to the console
        /// </summary>
        public static void ChallengeThree()
        {
            int rows = 5;

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion

        #region ChallengeFour
        public static void ChallengeFour()
        {
            Console.WriteLine("Example: Input: [1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1]");

            int[] arr = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };

            Console.WriteLine("The number that appears the most times: {0}", GetMostFrequent(arr));
        }

        public static int GetMostFrequent(int[] arr)
        {
            Dictionary<int, int> numFreq = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (numFreq.ContainsKey(arr[i]))
                    numFreq[arr[i]]++;
                else
                    numFreq.Add(arr[i], 1);
            }

            int most = 0;
            int count = 0;

            foreach (var item in numFreq)
            {
                if (item.Value > count)
                {
                    most = item.Key;
                    count = item.Value;
                }
            }

            return most;
        }
        #endregion
    }
}
