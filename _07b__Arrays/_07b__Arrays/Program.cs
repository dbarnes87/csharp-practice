using System;

namespace _07b__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = i + 10;
            //}

            //for (int j = 0; j < nums.Length; j++)
            //{
            //    Console.WriteLine("Element{0}: {1}", j, nums[j]);
            //}

            //int counter = 0;
            //foreach (int k in nums)
            //{
            //    Console.WriteLine("Element{0}: {1}", counter, k);
            //    counter++;
            //}

            string[] friends = { "Mike", "Julian", "Nick", "Katey", "Kelly" };

            foreach (string name in friends)
            {
                Console.WriteLine("Hello, {0}!", name);
            }
        }
    }
}
