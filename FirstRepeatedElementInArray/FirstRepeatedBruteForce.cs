namespace FirstRepeatedElementInArray
{
    public class FirstRepeatedBruteForce
    {
        public static int FirstRepeated(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                        return arr[i];
                }
            }

            return 0;
        }
    }
}
