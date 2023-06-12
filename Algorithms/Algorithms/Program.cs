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
                 * Heap sort
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
                Console.WriteLine("2. Searching algorithms");
                // Console.WriteLine("3. Pathing algorithms");
                Console.WriteLine("4. Common practice problems");
                Console.WriteLine("0. Quit");
                Console.WriteLine("=============================================");

                input = Console.ReadLine();

                if (input == "1")
                    HandleSortOption();
                else if (input == "2")
                    HandleSearchOption();
                else if (input == "4")
                    HandlePracticeProblemsOption();
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
                RequestArrayInput();

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

        static void HandleSortMenu(string arrayToSort)
        {
            string input;
            int[] processedArray;

            // Clean up the string containing the validated array.
            string arrayString = Regex.Replace(arrayToSort.Trim(), @"\s+", " ");

            do
            {
                // Convert to an integer array.
                processedArray = arrayString.Split(' ').Select(Int32.Parse).ToArray();

                Console.WriteLine("=============================================");
                Console.WriteLine("HOW WOULD YOU LIKE TO SORT THIS ARRAY?");
                Console.WriteLine("Your array: " + arrayString);
                Console.WriteLine("=============================================");
                Console.WriteLine("Please input a number to select an option:");
                Console.WriteLine("1. Merge sort");
                // Console.WriteLine("2. Quick sort");
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
                    // Consider edit to do 1 to A.length.
                    Sorts.MergeSort(processedArray, 0, processedArray.Length - 1);
                    Console.WriteLine("DONE");
                    Console.WriteLine();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Quick sort's order of growth is O(n log n):");
                    Console.WriteLine("OUTPUT:");
                    // Consider edit to do 1 to A.length
                    // Sorts.QuickSort(processedArray, 0, processedArray.Length - 1);
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

        static void HandleSearchOption()
        {
            string input;

            do
            {
                RequestArrayInput();

                input = Console.ReadLine();

                if (input == "0")
                    Console.WriteLine("...");
                else if (ValidateArrayInput(input))
                    HandleSearchMenu(input);
                else
                    Console.WriteLine("Please provide valid input.");
            }
            while (input != "0");
        }

        static void HandleSearchMenu(string arrayToSort)
        {
            string input;

            // Clean up the string containing the validated array.
            string arrayString = Regex.Replace(arrayToSort.Trim(), @"\s+", " ");

            // Convert to an integer array.
            int[] processedArray = arrayString.Split(' ').Select(Int32.Parse).ToArray();

            // Sort the array so it can be properly searched through.
            Sorts.MergeSort(processedArray, 0, processedArray.Length - 1, false);

            do
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("HOW WOULD YOU LIKE TO SEARCH THIS ARRAY?");
                Console.WriteLine("Your array has been sorted: ");
                Sorts.PrintArray(processedArray);
                Console.WriteLine("=============================================");
                Console.WriteLine("Please input a number to select an option:");
                Console.WriteLine("0. Go back.");
                Console.WriteLine("=============================================");

                input = Console.ReadLine();

                Console.WriteLine();
            }
            while (input != "0");
        }

        static void HandlePracticeProblemsOption()
        {
            string input;

            do
            {
                /*
                 * -- ALSO ADD --
                 * Palindromes
                 * Contact manager
                 *      - AddContact()
                 *      - AddListOfContacts()
                 *      - SearchForContact()
                 * Light and switch objects
                 * E-commerce store
                 * All ways to make a dollar with coins
                 * String maipulation, sorting, and searching
                 */
                Console.WriteLine("=============================================");
                Console.WriteLine("WHICH SOLUTION WOULD YOU LIKE TO SEE?");
                Console.WriteLine("=============================================");
                Console.WriteLine("1. Fizz Buzz");
                Console.WriteLine("2. Reverse an array");
                Console.WriteLine("0. Go back.");
                Console.WriteLine("=============================================");

                input = Console.ReadLine();

                if (input == "1")
                {
                    HandleFizzBuzzOption();
                }
                else if (input == "2")
                {
                    HandleReverseArrayOption();
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

        static void HandleFizzBuzzOption()
        {
            string input;

            do
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("PLEASE ENTER AN INTEGER SO WE KNOW WHAT");
                Console.WriteLine("NUMBER WE SHOULD FIZZBUZZ TO.");
                Console.WriteLine("Example: 128");
                Console.WriteLine();
                Console.WriteLine("Enter '0' to go back to main menu.");
                Console.WriteLine("=============================================");

                input = Console.ReadLine();

                if (input == "0")
                    Console.WriteLine("...");
                else if (ValidateIntegerInput(input))
                    PracticeProblems.FizzBuzz(int.Parse(input));
                else
                    Console.WriteLine("Please provide valid input.");
            }
            while (input != "0");
        }

        static void HandleReverseArrayOption()
        {
            string input;

            do
            {
                RequestArrayInput();

                input = Console.ReadLine();

                if (input == "0")
                    Console.WriteLine("...");
                else if (ValidateArrayInput(input))
                {
                    // Clean up the string containing the validated array.
                    string arrayString = Regex.Replace(input.Trim(), @"\s+", " ");
                    int[] processedArray = arrayString.Split(' ').Select(Int32.Parse).ToArray();
                    PracticeProblems.ReverseArray(processedArray);
                }
                else
                    Console.WriteLine("Please provide valid input.");
            }
            while (input != "0");
        }

        static void RequestArrayInput()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("PLEASE ENTER A SERIES OF INTEGERS. EACH");
            Console.WriteLine("VALUE SHOULD BE SEPARATED WITH A SPACE.");
            Console.WriteLine("Example: 10 4 152 2 1394");
            Console.WriteLine();
            Console.WriteLine("Enter '0' to go back to main menu.");
            Console.WriteLine("=============================================");
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

        static bool ValidateIntegerInput(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
