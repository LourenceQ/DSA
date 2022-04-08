using System;

namespace LinearSearchSorted
{
    public class LinearSearchSortedClass
    {
        public LinearSearchSortedClass(int[] sortedArr, int value)
        {
            SortedArr = sortedArr;
            Value = value;
        }

        public int[] SortedArr { get; private set; }
        public int Value { get; private set; }

        public bool LinearSearchSortedMethod()
        {
            for (int i = 0; i < SortedArr.Length; i++)
            {
                if(this.Value == this.SortedArr[i])
                    return true;
                
                else if(this.Value < this.SortedArr[i])
                    return false;                
            }
            
            return false;
        }
    }
}
