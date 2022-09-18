using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Search for elements in array:");

            int[] arr = { 12, 5, 3, 56, 32, 656, 33 };

            Console.WriteLine(string.Join(", ", arr));

            Console.WriteLine("Search for element 56...");

            int result = SearchElement.LinearSearch(arr, 56);
            SearchElement.PrintResult(result);

            Console.WriteLine("Search for element 88...");

            result = SearchElement.LinearSearch(arr, 88);
            SearchElement.PrintResult(result);
        }
    }
}
