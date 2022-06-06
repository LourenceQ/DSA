namespace LinearSearchSorted
{
    public class LinearSearchSortedClass
    {
        public static bool LinearSearchSortedMethod(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(value == arr[i])
                    return true;
                
                else if(value < arr[i])
                    return false;                
            }
            
            return false;
        }
    }
}
