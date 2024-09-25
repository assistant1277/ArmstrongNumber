using ArmstrongNumber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to check if it is Armstrong number ");
            int inputNumber = int.Parse(Console.ReadLine());
            Armstrong.CheckAndPrintArmstrong(inputNumber);
            Console.ReadKey();
        }
    }
}
