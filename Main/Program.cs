using System;
using LienarSearchUnsorted;
namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 45, 3, 78, 9, 3, 4 };
            Array.Sort(arr);
            int value = 4;

            var linearSearch = new LienarSearchUnsortedClass(arr, value);
            linearSearch.LinearSearchMethod().ToString();

        }
    }
}
