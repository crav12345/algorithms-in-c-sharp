using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Searches
    {
        public static void LinearSearch(int[] array, int target)
        {
            int numOccurrences = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    numOccurrences++;
                    Console.WriteLine("Appears at index: " + i);
                }
            }

            Console.WriteLine("The target, " + target + ", appears in the array " + numOccurrences + " time(s).");
        }

        public static void BinarySearch(int x, int[] array, int p, int r)
        {
            int low = p;
            int high = Math.Max(p, r + 1);
            int mid;

            while (low < high)
            {
                mid = (int)Math.Floor((low + high) / 2.0);

                if (x <= array[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if (high < array.Length && x == array[high])
            {
                Console.WriteLine("Found target, " + x + ", at index " + high);
            }
            else
            {
                Console.WriteLine("Couldn't find target, " + x + ", in your array.");
            }
        }
    }
}
