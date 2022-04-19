namespace FirstRepeatedElementInArray
{
    public class FirstRepeatedBruteForce
    {
        public int[] Arr { get; set; }

        public FirstRepeatedBruteForce(int[] arr)
        {
            Arr = arr;
        }

        public int FirstRepeated()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i+1; j < Arr.Length; j++)
                {
                    if(Arr[i] == Arr[j])
                        return Arr[i];
                }
            }

            return 0;
        }
    }
}
