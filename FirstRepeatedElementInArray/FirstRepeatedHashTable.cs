using System.Collections.Generic;
using static System.Console;

namespace FirstRepeatedElementInArray
{
    public class FirstRepeatedHashTable
    {
        public FirstRepeatedHashTable(int[] arr)
        {
            Arr = arr;
        }

        public int[] Arr { get; set; }

        public void FirstRepeatedHash()
        {
            HashSet<int> hs = new HashSet<int>();

            Write("\nRepeating elements are:");
            for (int i = 0; i < Arr.Length; i++)
            {
                if(hs.Contains(Arr[i]))
                    Write(" " + Arr[i]);
                else
                    hs.Add(Arr[i]);
            }
        }
    }
}