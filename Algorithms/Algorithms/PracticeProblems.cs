using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Class <c>PracticeProblems</c> implements solutions to common software
    /// developer technical assessment practice problems.
    /// </summary>
    class PracticeProblems
    {
        /// <summary>
        /// Method <c>FizzBuzz</c> creates and prints a string array where
        /// values at specific indexes are denoted "Fizz", "Buzz", or
        /// "FizzBuzz" based on the divisibility of their respective index by
        /// given numbers. This is on a 1-indexed list of numbers, so each
        /// index is actually compared to itself +1 since the array is
        /// 0-indexed.
        /// </summary>
        /// <param name="n"></param>
        public static void FizzBuzz(int n)
        {
            Console.Write("[ ");

            for (int i = 0; i < n; i++)
            {
                string denotion = "";

                if ((i + 1) % 3 == 0)
                    denotion += "Fizz";

                if ((i + 1) % 5 == 0)
                    denotion += "Buzz";

                if (denotion.Equals(""))
                    denotion = (i + 1).ToString();

                Console.Write(denotion);

                if (i < n - 1)
                    Console.Write(", ");
            }

            Console.WriteLine(" ]");
        }

        public static void ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }

            Sorts.PrintArray(reversedArray);
        }

        public static void MinimumCoins()
        {
            int value = 37;

            int[] coins = new int[5];
            coins[0] = 1;
            coins[1] = 5;
            coins[2] = 7;
            coins[3] = 10;
            coins[4] = 15;

            int[] table = new int[value + 1];

            // Base case for when value = 0.
            table[0] = 0;

            // Initialize table of subResults.
            for (int i = 1; i <= value; i++)
                table[i] = int.MaxValue;
            
            // Compute minimum coins from all values up to value.
            for (int i = 1; i <= value; i++)
            {
                // Go through all coins smaller than i.
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        int subResult = table[i - coins[j]];

                        if (subResult != int.MaxValue && subResult + 1 < table[i])
                            table[i] = subResult + 1;
                    }
                }
            }

            Sorts.PrintArray(table);
        }
    }
}
