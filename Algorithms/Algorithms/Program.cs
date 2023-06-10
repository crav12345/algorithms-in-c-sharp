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

                if (input != "0" && ValidateArrayInput(input))
                    HandleSortMenu(input);
                
                if (!ValidateArrayInput(input))
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

            // Process the string containing the validated array.
            string arrayString = Regex.Replace(arrayToSort, @"\s+", " ");
            int[] processedArray = arrayString.Split(' ').Select(Int32.Parse).ToArray();

            do
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("HOW WOULD YOU LIKE TO SORT THIS ARRAY?");
                Console.WriteLine("Your array: " + arrayString);
                Console.WriteLine("=============================================");
                Console.WriteLine("Please input a number to select an option:");
                // Console.WriteLine("1. Merge sort");
                // Console.WriteLine("2. Quick sort");
                Console.WriteLine("3. Insertion sort");
                // Console.WriteLine("4. Bubble sort");
                // Console.WriteLine("5. Selection sort");
                Console.WriteLine("0. Go back.");
                Console.WriteLine("=============================================");

                input = Console.ReadLine();

                Console.WriteLine();

                if (input == "3")
                {
                    Console.WriteLine("Insertion sort output:");
                    Sorts.InsertionSort(processedArray);
                    Console.WriteLine("DONE");
                }
            }
            while (input != "0");
        }
    }
}
