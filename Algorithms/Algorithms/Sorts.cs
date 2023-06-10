using System;

namespace Algorithms
{
    /// <summary>
    /// Class <c>Sorts</c> implements common sorting algorithms.
    /// </summary>
    public static class Sorts
    {
        /// <summary>
        /// Method <c>InsertionSort</c> sorts an array of integers by moving
        /// each integer into its proper position in the sorted subarray by
        /// comparing it to its preceeding values.
        /// </summary>
        /// <param name="array"></param>
        public static void InsertionSort(int[] array)
        {
            PrintArray(array);

            for (int j = 1; j < array.Length; j++)
            {
                int key = array[j];

                int i = j - 1;

                while ( i >= 0 && array[i] > key)
                {
                    array[i + 1] = array[i];
                    i = i - 1;
                }

                array[i + 1] = key;

                PrintArray(array);
            }
        }

        /// <summary>
        /// Method <c>BubbleSort</c> sorts an array of integers by repeatedly
        /// comparing and swapping adjacent elements that are out of order from
        /// left to right.
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSort(int[] array)
        {
            PrintArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j >= i + 1; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }

                PrintArray(array);
            }
        }

        /// <summary>
        /// Method <c>SelectionSort</c> sorts an array of integers by
        /// repeatedly finding the smallest remaining value in the unsorted
        /// subarray and swapping it with the last value in the sorted
        /// subarray.
        /// </summary>
        /// <param name="array"></param>
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i ++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }

                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;

                PrintArray(array);
            }
        }
        
        /// <summary>
        /// Method <c>PrintArray</c> prints the contents of an integer array.
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[] array)
        {
            Console.Write("[ ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i < array.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine(" ]");
        }
    }
}
