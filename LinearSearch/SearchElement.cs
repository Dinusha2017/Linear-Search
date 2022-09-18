using System;

namespace LinearSearch
{
    public static class SearchElement
    {
        /// <summary>
        /// Carries out linear, sequential search to find whether an element exists in an integer array.
        /// </summary>
        /// <param name="array">Array that needs to be searched</param>
        /// <param name="searchValue">Value that needs to be searched</param>
        /// <returns></returns>
        public static int LinearSearch(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    return i;
                }
            }

            // return -1 if value does not exist in the array
            return -1;
        }

        /// <summary>
        /// If element exists, prints index of array where element exists.
        /// Else, prints -1 to indicate element is not found.
        /// </summary>
        /// <param name="result"></param>
        public static void PrintResult(int result)
        {
            if (result == -1)
            {
                Console.WriteLine("Element is not found in array.");
            }

            Console.WriteLine($"Index of element in array: {result}");
        }
    }
}
