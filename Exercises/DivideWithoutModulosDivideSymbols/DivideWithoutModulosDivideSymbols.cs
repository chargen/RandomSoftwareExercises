using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.DivideWithoutModulosDivideSymbols
{
    public class DivideWithoutModulosDivideSymbols
    {
        public DivideWithoutModulosDivideSymbols()
        {
            Console.WriteLine("Exercise 11:");
            Console.WriteLine("Dividing two numbers without using the modulos or divide operators");
        }

        public void Run()
        {
            Console.WriteLine("Starting Exercise 11...");

            Divide(8, 2);
            Divide(9,2);
            Divide(5, 100);
            Divide(5, 2.3);

            Console.WriteLine("Exercise 11 Complete!");
        }

        private void Divide(double num1, double num2)
        {
            double smallerValue = 0;
            double biggerValue = 0;
            double remainder = 0;
            int wholeNumber = 0;

            Console.WriteLine("Num1/Num2: " + num1.ToString() + "/" + num2.ToString());

            if (num1 == num2)
            {
                Console.WriteLine("WholeNumber/Remaider: 1/0");
            }
            else
            {
                GetSmallestLargestValues(num1, num2, out smallerValue, out biggerValue);
                GetTotal(smallerValue, biggerValue, out wholeNumber, out remainder);
                
                Console.WriteLine("WholeNumber/Remaider: " + wholeNumber.ToString() + "/" + remainder.ToString());
            }
        }

        private void GetSmallestLargestValues(double num1, double num2, out double smallerValue, out double biggerValue)
        {
            if (num1 > num2)
            {
                smallerValue = num2;
                biggerValue = num1;
            }
            else
            {
                smallerValue = num1;
                biggerValue = num2;
            }
        }

        private void GetTotal(double smallerValue, double biggerValue, out int wholeNumber, out double remainder)
        {
            int ctr = 0;
            double total = 0;
            while (total < biggerValue)
            {
                total = total + smallerValue;
                ctr++;
            }

            remainder = Math.Abs(total - biggerValue);
            wholeNumber = Math.Abs(ctr - (int)remainder);
        }
    }
}
