using LienarSearchUnsorted;
using LinearSearchSorted;
using BinarySearch;
using BinarySearchRecursion;
using FirstRepeatedElementInArray;
using static System.Console;
using RemoveDuplicatesInIntegerList;
using FindMissingNumberInIntegerList;
using System;
using System.Diagnostics;
using Timing;
using ArrayBase;
using BubbleSort;
using SelectionSort;

namespace SearchAlgorithms
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[] arr = { 1, 45, 3, 78, 9, 3, 4 };
            int[] arr2 = { 1, 3, 3, 4, 9, 43, 78 };
            int[] arr3 = { 1, 45, 3, 78, 9, 3, 4, 1, 45 };
            int[] arr4 = new int[] { 34, 56, 77, 1, 5, 6, 6, 6, 6, 6, 6, 7, 8, 10, 34, 20 };
            int[] nums = new int[100000];

            int value = 4;
            int value2 = 78;             

            var res1 = LienarSearchUnsortedClass
                .LinearSearchUnsortedMethod(arr3, value);

            var res2 = LinearSearchSortedClass
                .LinearSearchSortedMethod(arr3, value);

            var res3 = BinarySearchClass
                .BinarySearchMethod(arr2, value2);

            var res4 = BinarySearchRecursionClass
                .BinarySearchRecursionMethod(arr2, arr2.Length, value2);

            var res5 = FirstRepeatedBruteForce
                .FirstRepeated(arr);

            var res6 = RemoveDucplicates
                .RemoveDup(arr4);

            var bs = BubbleSortClass
                .BubbleSortMethod(arr2); 
            
            var ss = SelectionSortClass
                .SelectionSortMethod(arr); 

            // System.Console.Write("Duplicates removed: ");
            // foreach (var i in res6)
            // {
            //     Write($"{i} ");
            // }

            // var res7 = FindMissingNumberSolution1
            //     .FindMissing(arr3);

            // WriteLine(
            //     $"\nLienarSearchUnsorted: {res1}\n" +
            //     $"LienarSearchSorted: {res2}\n" +
            //     $"BinarySearchRecursion: {res3}\n" +
            //     $"BinarySearchRecursion: {res4}\n" +
            //     $"FirstRepeatedElementBruteForce: {res5}\n" +
            //     $"Find Missing Number Solution1: {res7}");

            // FirstRepeatedHashTable.FirstRepeatedHash(arr3);


            // BuildArray(nums);
            // TimerClass tObj = new TimerClass();
            // tObj.startTime();
            // DisplayNums(nums);
            // tObj.StopTime();
            
            // Console.WriteLine($"Tempo (.NET):  {tObj.Result().TotalSeconds}");

            // CArray cArr = new CArray(7); 
            // for(int i=0; i<=6; i++)
            //     cArr.Insert(i);
            // cArr.DisplayElements();

            CArray randNums = new CArray(10);
            Random rnd = new Random(10);
            for (int i = 0; i < 10; i++)
                randNums.Insert((int) (rnd.NextDouble() * 100));
            randNums.DisplayElements();

            

        }
        
        static void BuildArray(int[] arr)
        {
            for (int i = 0; i <= 99999; i++)
                arr[i] = i;
        }
        static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                Console.Write(arr[i] + " ");
        }
    }
}
