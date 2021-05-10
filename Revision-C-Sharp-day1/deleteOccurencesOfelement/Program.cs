using System;

namespace deleteOccurencesOfelement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Solution.DeleteNthElement(new int[] { 20, 37, 20, 21, 37 }, 1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
