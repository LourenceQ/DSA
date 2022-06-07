using System;

namespace RemoveDuplicatesInIntegerList
{
    public class RemoveDucplicates
    {
        public static int[] RemoveDup(int[] arr)
        {
            int j = 0;
            Array.Sort(arr);
            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i] != arr[j])
                {
                    j++;
                    arr[j] = arr[i];
                }
            }

            int[] ret = new int[j+1];
            Array.Copy(arr, ret, j+1);

            return ret;
        }
    }
}
