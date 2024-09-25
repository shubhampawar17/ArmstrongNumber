using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber.model
{
    internal class Armstrong
    {
        public static bool IsArmstrong(int num)
        {
            int sum = 0, temp = num, rem;
            int digits = num.ToString().Length;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (int)Math.Pow(rem, digits);
                num = num + 10;
            }

            return temp == sum;
        }
    }
}
