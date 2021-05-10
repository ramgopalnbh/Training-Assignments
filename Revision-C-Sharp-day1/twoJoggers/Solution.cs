﻿using System;
using System.Collections.Generic;
using System.Text;

namespace twoJoggers
{
    public class Solution
    {
        static int GCD(int num1, int num2)
        {
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            int result = num2 % num1;

            if (result != 0)
                return GCD(num1, result);

            return num1;
        }

        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            int gcd = GCD(x, y);
            int lcm = (x * y) / (gcd);
            return new Tuple<int, int>(lcm / x, lcm / y);
        }
    }
}
