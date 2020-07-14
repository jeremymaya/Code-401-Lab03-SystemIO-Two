using System;

namespace SystemIOTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChallengeTwo();
        }


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

            return sum/count;
        }
    }
}
