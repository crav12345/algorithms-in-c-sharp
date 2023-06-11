using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            string input;

            do
            {
                /*
                 * -- ALSO ADD --
                 * Binary search
                 * Linear search
                 * Depth-first search
                 * Breadth-first search
                 * Dijkstra's algorithm
                 * Bellman-Ford algorithm
                */

                Console.WriteLine("=============================================");
                Console.WriteLine("WELCOME TO ALGORITHMS IN C#");
                Console.WriteLine("=============================================");
                Console.WriteLine("Please input a number to select an option:");
                Console.WriteLine("1. Sorting algorithms");
                // Console.WriteLine("2. Searching algorithms");
                // Console.WriteLine("3. Pathing algorithms");
                Console.WriteLine("0. Quit");
                Console.WriteLine("=============================================");

                input = Console.ReadLine();

                if (input == "1")
                    HandleSortOption();
                else if (input == "0")
                    Console.WriteLine("Goodbye!");
                else
                    Console.WriteLine("That doesn't seem to be an option!");

            }
            while (input != "0");
        }

        static void HandleSortOption()
        {
            string input;

            do
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("PLEASE ENTER A LIST OF NUMBERS TO SORT. EACH");
                Console.WriteLine("VALUE SHOULD BE SEPARATED WITH A SPACE.");
                Console.WriteLine("Example: 10 4 152 2");
                Console.WriteLine();
                Console.WriteLine("Enter '0' to go back to main menu.");
                Console.WriteLine("=============================================");

                input = Console.ReadLine();

                if (input == "0")
                    Console.WriteLine("...");
                else if (ValidateArrayInput(input))
                    HandleSortMenu(input);
                else
                    Console.WriteLine("Please provide valid input.");
            }
            while (input != "0");
        }

        static bool ValidateArrayInput(string input)
        {
            bool result = true;

            Char[] charArray = input.ToCharArray();

            foreach (char character in charArray)
            {
                if (!Char.IsWhiteSpace(character) && !Char.IsDigit(character))
                {
                    result = false;
                }
            }

            return result;
        }

        static void HandleSortMenu(string arrayToSort)
        {
            string input;
            int[] processedArray;

            // Process the string containing the validated array.
            string arrayString = Regex.Replace(arrayToSort, @"\s+", " ");

            do
            {
                processedArray = arrayString.Split(' ').Select(Int32.Parse).ToArray();

                Console.WriteLine("=============================================");
                Console.WriteLine("HOW WOULD YOU LIKE TO SORT THIS ARRAY?");
                Console.WriteLine("Your array: " + arrayString);
                Console.WriteLine("=============================================");
                Console.WriteLine("Please input a number to select an option:");
                Console.WriteLine("1. Merge sort");
                Console.WriteLine("2. Quick sort");
                Console.WriteLine("3. Insertion sort");
                Console.WriteLine("4. Bubble sort");
                Console.WriteLine("5. Selection sort");
                Console.WriteLine("0. Go back.");
                Console.WriteLine("=============================================");

                input = Console.ReadLine();

                Console.WriteLine();

                if (input == "1")
                {
                    Console.WriteLine("Merge sort's order of growth is O(n log n):");
                    Console.WriteLine("OUTPUT:");
                    Sorts.MergeSort(processedArray, 0, processedArray.Length - 1);
                    Console.WriteLine("DONE");
                    Console.WriteLine();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Quick sort's order of growth is O(n log n):");
                    Console.WriteLine("OUTPUT:");
                    //Sorts.QuickSort(processedArray, 0, processedArray.Length - 1);
                    Console.WriteLine("DONE");
                    Console.WriteLine();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Insertion sort's order of growth is O(n^2):");
                    Console.WriteLine("OUTPUT:");
                    Sorts.InsertionSort(processedArray);
                    Console.WriteLine("DONE");
                    Console.WriteLine();
                }
                else if (input == "4")
                {
                    Console.WriteLine("Bubble sort's order of growth is O(n^2):");
                    Console.WriteLine("OUTPUT:");
                    Sorts.BubbleSort(processedArray);
                    Console.WriteLine("DONE");
                    Console.WriteLine();
                }
                else if (input == "5")
                {
                    Console.WriteLine("Selection sort's order of growth is O(n^2):");
                    Console.WriteLine("OUTPUT:");
                    Sorts.SelectionSort(processedArray);
                    Console.WriteLine("DONE");
                    Console.WriteLine();
                }
                else if (input == "0")
                {
                    Console.WriteLine("...");
                }
                else
                    Console.WriteLine("Please provide valid input.");
            }
            while (input != "0");
        }
    }
}
