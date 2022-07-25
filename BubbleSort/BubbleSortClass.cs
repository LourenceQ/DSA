namespace BubbleSort
{
    public class BubbleSortClass
    {
        public static int[] BubbleSortMethod(int[] arr)
        {
            int temp;
            for (int outer = arr.Length-1; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                    if ((int)arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
            }

            return arr;
        }
    }
}