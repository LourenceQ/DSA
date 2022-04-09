using System;
using LienarSearchUnsorted;
using LinearSearchSorted;
using BinarySearch;


namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
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

            System.Console.WriteLine($"{res1}\n{res2}\n{res3}");

        }
    }
}
