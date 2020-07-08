using System;

namespace SystemIOTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Please enter 3 numbers:");
            string input = Console.ReadLine();
            Console.WriteLine("The product of these 3 numbers is: {0}", ChallengeOne(input));
        }

        //Write a program that asks the user for 3 numbers.Return the product of these 3 numbers multiplied together. If the user puts in less than 3 numbers, return 0; If the user puts in more than 3 numbers, only multiply the first 3. If the number is not a number, default that value to 1.

        public static int ChallengeOne(string input)
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
    }
}
