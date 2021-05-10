using System;

namespace sumOfDiffBWProductLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][] { new int[] { 1, 1 }, new int[] { 0, 0 }, new int[] { 13, 91 } };
            Console.WriteLine(Solution.SumDifferencesBetweenProductsAndLCMs(arr));
        }
    }
}
