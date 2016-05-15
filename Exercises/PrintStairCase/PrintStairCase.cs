using System;

namespace Exercises.PrintStairCase
{
    public class PrintStairCase
    {
        public PrintStairCase()
        {
            Console.WriteLine("Exercise 12:");
            Console.WriteLine("Print staircase for supplied max row length");
        }

        public void Run()
        {
            Console.WriteLine("Starting Exercise 12...");

            RunExercise(4);
            RunExercise(9);
            RunExercise(56);

            Console.WriteLine("Exercise 12 Complete!");
        }

        private void RunExercise(int maxRowLength)
        {
            bool cont = true;

            int ctr = 0;
            while (ctr <= maxRowLength)
            {
                PrintStairCaseRow(ctr, maxRowLength);
                ctr++;
            }
        }

        private void PrintStairCaseRow(int currentRow, int maxRowLength)
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
    }
}
