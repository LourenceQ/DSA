namespace LienarSearchUnsorted
{
    /// <summary>
    /// this is a class library with an unordered linear array search method
    /// </summary>
    public class LienarSearchUnsortedClass
    {
        public static bool LinearSearchUnsortedMethod(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (value == arr[i])
                {
                    return true;
                }
            }

            return false;
        }        
    }
}
