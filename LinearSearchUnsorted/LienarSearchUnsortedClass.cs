namespace LienarSearchUnsorted
{

    /// <summary>
    /// this is a class library with an unordered linear array search method
    /// </summary>
    public class LienarSearchUnsortedClass
    {
        public LienarSearchUnsortedClass(int[] sortedArr, int value)
        {
            SortedArr = sortedArr;
            Value = value;
        }

        public int[] SortedArr { get; private set; }
        
        public int Value { get; private set; }        

        public bool LinearSearchMethod()
        {
            for (int i = 0; i < this.SortedArr.Length; i++)
            {
                if (this.Value == this.SortedArr[i])
                {
                    return true;
                }
            }

            return false;
        }        
    }
}
