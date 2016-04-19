using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercises.Matrix
{
    public class Matrix
    {
        //print out the difference between the two diagonals in the provided inpu
        //11 2   4
        //4  5   6
        //10 8 -12
        private int n = 0;
        private int[][] a = null;

        public void RunTotals()
        {
            GetInput();

            int diagnonalSumOne = AddNumbers(true);
            int diagonnalSumTwo = AddNumbers(false);
            int sum = Math.Abs(diagnonalSumOne - diagonnalSumTwo);
            
            Console.WriteLine("Sum is " + sum);   
        }

        private int AddNumbers(bool firstDiagonal)
        {
            int sum = 0;
            int firstDimensionCtr = 0;
            int secondDimensionCtr = 0;
            int loopCtr = 0;

            if (!firstDiagonal)
                firstDimensionCtr = a.Length - 1;

            while (loopCtr < n)
            {
                sum += a[firstDimensionCtr][secondDimensionCtr];

                if (firstDiagonal)
                    firstDimensionCtr++;
                else
                    firstDimensionCtr--;

                secondDimensionCtr++;
                loopCtr++;
            }
            
            return sum;
        }
        private void GetInput()
        {
            n = 3;
            a = new int[n][];
            string[] a_temp = "11 2 4".Split(' ');
            a[0] = Array.ConvertAll(a_temp, Int32.Parse);

            a_temp = "4 5 6".Split(' ');
            a[1] = Array.ConvertAll(a_temp, Int32.Parse);

            a_temp = "10 8 -12".Split(' ');
            a[2] = Array.ConvertAll(a_temp, Int32.Parse);
        }
    }
}
