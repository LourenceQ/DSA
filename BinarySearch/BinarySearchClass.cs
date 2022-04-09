using System;

namespace BinarySearch
{
    public class BinarySearchClass
    {
        public BinarySearchClass(int[] arr, int value)
        {
            Arr = arr;
            Value = value;
        }

        public int[] Arr { get; private set; }
        public int Value { get; set; }

        public bool BinarySearchMethod()
        {
            int r = Arr.Length-1;
            int l = 0;
            int mid;

            while(l <= r)
            {
                mid = (l + r) / 2;

                if(Arr[mid] == Value)
                    return true;

                else if(Arr[mid] < Value)
                    l = mid + 1;

                else 
                    r = mid - 1;
            }

            return false;
        }
    }
}
