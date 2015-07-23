using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise3
{
    public class ReturnNthLargestElementFromArray
    {
        private IList<int> values = null;

        public ReturnNthLargestElementFromArray()
        {
            Console.WriteLine("Exercise 3:");
            Console.WriteLine("Return the 4th largest element in an unsorted array");
            values = PopulateValues();
        }

        private IList<int> PopulateValues()
        {
            IList<int> values = new List<int>();

            values.Add(10);
            values.Add(1);
            values.Add(7);
            values.Add(4);
            values.Add(6);
            values.Add(5);
            values.Add(3);
            values.Add(8);
            values.Add(2);
            values.Add(9);

            return values;
        }

        public void Run()
        {
            Console.WriteLine("Starting Exercise 3...");

            DisplayValues();

            SortValues();

            DisplayValues();

            Console.WriteLine("4th largest value is " + values[3]);
            
            Console.WriteLine("Exercise 3 is completed!");
        }

        private void DisplayValues()
        {
            foreach(int value in values)
                Console.WriteLine(value.ToString());
            
            Console.WriteLine("");
        }

        private void SortValues()
        {
            int outerCtr = 0;
            int innerCtr = 0;
            int maxRecords = values.Count-1;

            while(outerCtr <= maxRecords)
            {
                innerCtr = 0;

                while(innerCtr <= maxRecords)
                {
                    if ((innerCtr+1)>maxRecords)
                        break;

                    int curValue = values[innerCtr];
                    int nxtValue = values[innerCtr+1];

                    if (curValue > nxtValue)
                    {
                        values[innerCtr+1] = curValue;
                        values[innerCtr] = nxtValue;
                    }

                    DisplayValues();

                    innerCtr++;
                }

                outerCtr++;
            }
        }
    }
}
