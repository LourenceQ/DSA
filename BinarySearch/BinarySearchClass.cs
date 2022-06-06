namespace BinarySearch
{
    public class BinarySearchClass
    {

        public static bool BinarySearchMethod(int[] arr, int value)
        {
            int r = arr.Length-1;
            int l = 0;
            int mid;

            while(l <= r)
            {
                mid = (l + r) / 2;

                if(arr[mid] == value)
                    return true;

                else if(arr[mid] < value)
                    l = mid + 1;

                else 
                    r = mid - 1;
            }

            return false;
        }
    }
}
