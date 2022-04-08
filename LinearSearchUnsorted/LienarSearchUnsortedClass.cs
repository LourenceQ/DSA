namespace LienarSearchUnsorted
{
    /// <summary>
    /// this is a class library with an unordered linear array search method
    /// </summary>
    public class LienarSearchUnsortedClass
    {
        public LienarSearchUnsortedClass(int[] unsortedArr, int value)
        {
            UnsortedArr = unsortedArr;
            Value = value;
        }

        public int[] UnsortedArr { get; private set; }
        
        public int Value { get; private set; }        

        public bool LinearSearchUnsortedMethod()
        {
            for (int i = 0; i < this.UnsortedArr.Length; i++)
            {
                if (this.Value == this.UnsortedArr[i])
                {
                    return true;
                }
            }

            return false;
        }        
    }
}
