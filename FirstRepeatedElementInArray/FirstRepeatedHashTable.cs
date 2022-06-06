using System.Collections.Generic;
using static System.Console;

namespace FirstRepeatedElementInArray
{
    public class FirstRepeatedHashTable
    {
        public static void FirstRepeatedHash(int[] arr)
        {
            HashSet<int> hs = new HashSet<int>();

            Write("Repeating elements are:");
            for (int i = 0; i < arr.Length; i++)
            {
                if(hs.Contains(arr[i]))
                    Write(" " + arr[i]);
                else
                    hs.Add(arr[i]);
            }
        }
    }
}