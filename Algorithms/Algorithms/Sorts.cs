using System;

namespace Algorithms
{
    public static class Sorts
    {
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
