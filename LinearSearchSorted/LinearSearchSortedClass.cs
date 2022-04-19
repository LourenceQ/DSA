namespace LinearSearchSorted
{
    public class LinearSearchSortedClass
    {
        public LinearSearchSortedClass(int[] arr, int value)
        {
            Arr = arr;
            Value = value;
        }

        public int[] Arr { get; private set; }
        public int Value { get; private set; }

        public bool LinearSearchSortedMethod()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if(this.Value == this.Arr[i])
                    return true;
                
                else if(this.Value < this.Arr[i])
                    return false;                
            }
            
            return false;
        }
    }
}
