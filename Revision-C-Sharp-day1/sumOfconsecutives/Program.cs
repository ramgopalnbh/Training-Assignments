﻿using System;

namespace sumOfconsecutives
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = Solution.SumConsecutives(new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 });
            result.ForEach(item => Console.WriteLine(item));
        }
    }
}
