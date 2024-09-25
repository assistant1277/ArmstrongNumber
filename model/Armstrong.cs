using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber.model
{
    public class Armstrong
    {
        public static int CalculatePower(int baseValue, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseValue;
            }
            return result;
        }
        public static void CheckAndPrintArmstrong(int number)
        {
            int numDigits = number.ToString().Length;
            int sumOfPowers = 0;
            int tempNumber = number;

            while (tempNumber > 0)
            {
                int lastDigit = tempNumber % 10;
                sumOfPowers += CalculatePower(lastDigit, numDigits);
                tempNumber /= 10;
            }
            string resultMessage = sumOfPowers == number ? $"{number} is Armstrong number" : $"{number} not an Armstrong number";

            Console.WriteLine(resultMessage);
        }
    }
}
