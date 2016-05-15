using System;

namespace Exercises.PrintPositiveNegativeZeroNumbers
{
    public class PrintPositiveNegativeZeroNumbers
    {
        public PrintPositiveNegativeZeroNumbers()
        {
            Console.WriteLine("Exercise 13:");
            Console.WriteLine("Print number of positive, negative and zero numbers in the provided array");
        }

        public void Run()
        {
            Console.WriteLine("Starting Exercise 13...");

            RunExercise("4 -9 1 24 -98 4");

            Console.WriteLine("Exercise 13 Complete!");
        }

        private void RunExercise(string line)
        {
            string[] values = line.Split(' ');
            int[] arr = Array.ConvertAll(values, Int32.Parse);

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

            Console.WriteLine((positiveNumbers / values.Length).ToString());
            Console.WriteLine((negativeNumbers / values.Length).ToString());
            Console.WriteLine((zeroNumbers / values.Length).ToString());
        }
    }
}
