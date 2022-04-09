namespace LienarSearchUnsorted
{
    /// <summary>
    /// this is a class library with an unordered linear array search method
    /// </summary>
    public class LienarSearchUnsortedClass
    {
        public LienarSearchUnsortedClass(int[] arr, int value)
        {
            Arr = arr;
            Value = value;
        }

        public int[] Arr { get; private set; }
        
        public int Value { get; private set; }        

        public bool LinearSearchUnsortedMethod()
        {
            for (int i = 0; i < this.Arr.Length; i++)
            {
                if (this.Value == this.Arr[i])
                {
                    return true;
                }
            }

            return false;
        }        
    }
}
