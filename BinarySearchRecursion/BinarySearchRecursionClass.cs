namespace BinarySearchRecursion
{
    public class BinarySearchRecursionClass
    {
        public bool BinarySearchRecursionMethod(int[] Arr, int size, int Value)
        {
            int left = 0;
            int right = size - 1;
            return BinarySearchRecursionMethodUtil(Arr, left, right, Value);
        }

        public static bool BinarySearchRecursionMethodUtil(int[] Arr, int left, int right, int Value)
        {
            if (left > right)
                return false;

            int mid = (left + right) / 2;

            if (Arr[mid] == Value)
                return true;

            else if (Arr[mid] < Value)
                return BinarySearchRecursionMethodUtil(Arr, mid + 1, right, Value);

            else
            {
                return BinarySearchRecursionMethodUtil(Arr, left, mid - 1, Value);
            }
        }


    }
}
