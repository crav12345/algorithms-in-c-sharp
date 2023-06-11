using System;

namespace Algorithms
{
    /// <summary>
    /// Class <c>Sorts</c> implements common sorting algorithms.
    /// </summary>
    public static class Sorts
    {
        /// <summary>
        /// Method <c>MergeSort</c> sorts an array of integers using a divide-
        /// and-conquer technique. It recursively breaks the array into
        /// subarrays until it cannot anymore. Then it sorts the subarrays and
        /// merges them back together, taking the smallest of the two values at
        /// the top of the two subarrays. This process is done until the sorted
        /// contents are merged back into the full-size array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p"></param>
        /// <param name="r"></param>
        public static void MergeSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q = (int)MathF.Floor((p + r) / (float)2.0);
                MergeSort(array, p, q);
                MergeSort(array, q + 1, r);
                Merge(array, p, q, r);
            }
        }

        /// <summary>
        /// Method <c>Merge</c> completes merges for the recursive MergeSort.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="r"></param>
        public static void Merge(int[] array, int p, int q, int r)
        {
            int n1 = q - p + 1; // Length of subarray A[p...q].
            int n2 = r - q;     // Length of subarray A[q + 1...r].
            
            int i, j, k;

            // Initialize the subarrays.
            int[] lt = new int[n1];
            int[] rt = new int[n2];

            // Fill left subarray.
            for (i = 0; i < n1; i++)
                lt[i] = array[p + i];

            // Fill right subarray.
            for (j = 0; j < n2; j++)
                rt[j] = array[q + 1 + j];

            Console.Write("Subarrays: ");
            PrintArray(lt, false);
            PrintArray(rt);

            i = 0;
            j = 0;

            // Merge the subarrays by adding smallest top value.
            for (k = p; k <= r; k++)
            {
                if ((i < n1 && j == n2) || (i < n1 && lt[i] <= rt[j]))
                {
                    array[k] = lt[i];
                    i++;
                }
                else
                {
                    array[k] = rt[j];
                    j++;
                }

                Console.WriteLine("Add next sorted value:");
                PrintArray(array);
            }
        }

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
        public static void PrintArray(int[] array, bool skipLine = true)
        {
            Console.Write("[ ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i < array.Length - 1)
                    Console.Write(", ");
            }

            Console.Write(" ]");

            if (skipLine)
                Console.WriteLine();
        }
    }
}
