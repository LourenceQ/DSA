using LienarSearchUnsorted;
using LinearSearchSorted;
using BinarySearch;
using BinarySearchRecursion;
using FirstRepeatedElementInArray;
using static System.Console;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr3 = { 1, 45, 3, 78, 9, 3, 4, 1, 45 };            

            int[] arr = { 1, 45, 3, 78, 9, 3, 4 };            
            int value = 4;
            var linearSearchUnsorted = new LienarSearchUnsortedClass(arr, value);
            var res1 =  linearSearchUnsorted.LinearSearchUnsortedMethod().ToString();

            int[] arr2 = {1, 3, 3, 4, 9, 43, 78};
            int value2 = 78;
            var linearSearchSorted = new LinearSearchSortedClass(arr2, value2);
            var res2 = linearSearchSorted.LinearSearchSortedMethod();

            var binSearch = new BinarySearchClass(arr2, value2);
            var res3 = binSearch.BinarySearchMethod();

            var binSearchRecursion = new BinarySearchRecursionClass();
            var res4 = binSearchRecursion.BinarySearchRecursionMethod(arr2, arr2.Length, value2);

            var firstRepeatedBruteForce = new FirstRepeatedBruteForce(arr);
            var res5 = firstRepeatedBruteForce.FirstRepeated();

            FirstRepeatedHashTable firstRepeatedHashTable = new FirstRepeatedHashTable(arr3);

            int[] arr4 = new int[] {34, 56, 77, 1, 5, 6, 6, 6, 6, 6, 6, 7, 8, 10, 34, 20};
            var firstRepeatedCounting = new FirstRepeatedCounting(arr4, arr4.Length, 76);
           

            WriteLine(
                $"LienarSearchUnsorted: {res1}\n" +
                $"LienarSearchSorted: {res2}\n" +
                $"BinarySearchRecursion: {res3}\n" +
                $"BinarySearchRecursion: {res4}\n" +
                $"FirstRepeatedElementBruteForce: {res5}");
            firstRepeatedHashTable.FirstRepeatedHash();
            firstRepeatedCounting.PrintRepeatingCounting();

        }
    }
}
