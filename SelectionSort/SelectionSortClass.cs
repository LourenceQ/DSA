using System;

namespace SelectionSort
{
    public class SelectionSortClass
    {
        public static int[] SelectionSortMethod(int[] arr)
        {
            int min, temp;
            for (int outer = 0; outer <= arr.Length-1; outer++)
            {
                min = outer;
                for (int inner = outer+1; inner < arr.Length; inner++)
                {
                    if(arr[inner] < arr[min])
                        min = inner;
                }

                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }

            return arr;
        }
    }
}
