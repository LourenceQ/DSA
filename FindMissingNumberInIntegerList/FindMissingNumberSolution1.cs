namespace FindMissingNumberInIntegerList
{
    public class FindMissingNumberSolution1
    {
        public static int FindMissing(int[] arr)
        {
            int i, j, found = 0;
            for (i = 1; i <= arr.Length; i++)
            {
                found = 0;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                    {
                        found = 1;
                        break;
                    }
                }
                if (found == 0)
                {
                    return i;
                }
            }

            return int.MaxValue;
        }
    }
}
