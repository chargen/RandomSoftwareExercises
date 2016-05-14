using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercises;

namespace RandomSoftwareExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Main m = new Main();
            m.Run();
        }

        /// <summary>
        /// print number of positive, negative and zero numbers in the provided array
        /// </summary>
        private static void RunExercise()
        {
            int n = 6;
            string[] arr_temp = "-4 3 -9 0 4 1".Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            double positiveNumbers = 0;
            double negativeNumbers = 0;
            double zeroNumbers = 0;

            foreach (int arrValue in arr)
            {
                if (arrValue > 0)
                    positiveNumbers++;
                else if (arrValue < 0)
                    negativeNumbers++;
                else
                    zeroNumbers++;
            }

            Console.WriteLine((positiveNumbers / n).ToString());
            Console.WriteLine((negativeNumbers / n).ToString());
            Console.WriteLine((zeroNumbers / n).ToString());
        }

        /// <summary>
        /// print out stair symbols for supplied number
        /// </summary>
        private static void RunExercise2()
        {
            bool cont = true;

            while (cont)
            {
                int maxRowLength = Convert.ToInt32(Console.ReadLine());
                int ctr = 1;

                while (ctr <= maxRowLength)
                {
                    PrintStairCaseRow(ctr, maxRowLength);
                    ctr++;
                }
            }
        }
        private static void PrintStairCaseRow(int currentRow, int maxRowLength)
        {
            string row = string.Empty;
            int ctr = 0;
            int numOfSymbols = currentRow + 1;
            int numOfSpaces = maxRowLength - numOfSymbols;

            while (ctr < maxRowLength)
            {
                if (ctr <= numOfSpaces)
                    row += " ";
                else
                    row += "#";

                ctr++;
            }

            Console.WriteLine(row);
        }

        //TODO - update this to handle non-even numbers
        private static double Divide(double num1, double num2)
        {
            double result = 0;
            double smallerValue = 0;
            double biggerValue = 0;

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

            int ctr = 0;
            double total = 0;
            while (total < biggerValue)
            {
                total = total + smallerValue;
                ctr++;
            }

            result = ctr + (biggerValue - total);

            return result;
        }
    }
}
