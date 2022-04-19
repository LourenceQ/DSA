using static System.Console;

namespace FirstRepeatedElementInArray
{
    public class FirstRepeatedCounting
    {
        public int[] Arr { get; set; }
        public int Size { get; set; }
        public int Range { get; set; }
        

        public FirstRepeatedCounting(int[] arr, int s, int r)
        {
            Arr = arr;
            Size = s;
            Range = r;            
        }

        public void PrintRepeatingCounting()
        {
            int[] count = new int[Range];
            for (int i = 0; i < Size; i++)
            {
                count[i] = 0;
            }
            
            WriteLine("\nRepeating elements are ");
            for(int i=0; i<Size; i++)
            {
                if(count[Arr[i]] == 1)
                    WriteLine(" " + Arr[i]);
                
                else
                    count[Arr[i]]++;
            }            
        }
    }
}