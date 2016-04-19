using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        bool cont = true;
        int ctr = 1;
        int maxRowLength = n;

        while (cont)
        {
            PrintStairCaseRow(ctr, maxRowLength);

            if (ctr >= n)
                break;
            else
                ctr++;
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
    //static void Main(String[] args)
    //{
    //    bool cont = true;

    //    while (cont)
    //    {
    //        int maxRowLength = Convert.ToInt32(Console.ReadLine());
    //        int ctr = 1;

    //        while (ctr <= maxRowLength)
    //        {
    //            PrintStairCaseRow(ctr, maxRowLength);
    //            ctr++;
    //        }
    //    }
    //}

    //private static void PrintStairCaseRow(int currentRow, int maxRowLength)
    //{
    //    string row = string.Empty;
    //    int ctr = 0;
    //    int numOfSymbols = currentRow + 1;
    //    int numOfSpaces = maxRowLength - numOfSymbols;

    //    while (ctr < maxRowLength)
    //    {
    //        if (ctr <= numOfSpaces)
    //            row += " ";
    //        else
    //            row += "#";

    //        ctr++;
    //    }

    //    Console.WriteLine(row);
    //}
}
