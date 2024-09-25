using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber.model
{
    internal class Armstrong
    {
        public static bool IsArmstrong(int number)
        {
            int sum = 0, temp = number, remainder;
            int digits = number.ToString().Length;

            while (number > 0)
            {
                remainder = number % 10;
                sum = sum + (int)Math.Pow(remainder, digits);
                number = number / 10;
            }

            return temp == sum;
        }
    }
}
