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
    }
}
