using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise9
{ 
    public class FindLgestSeqDescIncrInLargerSeq
    {
        //TODO - not complete...still need to handle smaller increasing sub rows as well as being able to
        //handle longer sub increasing rows in even longer arrays
        private int[] values = {10, 3, 7, 9, 0, 15};
        private IList<int> increasingValues = new List<int>();

        public FindLgestSeqDescIncrInLargerSeq()
        {
            Console.WriteLine("Exercise 9:");
            Console.WriteLine("Given an array of integers. Find the largest increasing sub sequence of integers in the array");            
        }        

        public void Run()
        {
            Console.WriteLine("Starting Exercise 9...");  

            DisplayBeginningValues();
            DisplaySubIncreasingValues();

            RunExercise();
            
            DisplayBeginningValues();
            DisplaySubIncreasingValues();

            Console.WriteLine("Exercise 9 is completed!");
        }        

        private void DisplayBeginningValues()
        {
            Console.WriteLine("Beginning Values:");
            foreach(int value in values)
                Console.WriteLine(value.ToString());

            Console.WriteLine("");
        }
        
        private void DisplaySubIncreasingValues()
        {
            Console.WriteLine("Sub Increasing Values:");
            foreach(int value in increasingValues)
                Console.WriteLine(value.ToString());

            Console.WriteLine("");
        }
    
        private void RunExercise()
        {
            int startIndex = 0;
            int value = 0;
            int nextValue = 0;
            int maxIndex = values.Length - 1;
            int ctr = 0;

            while(true)
            {
                if ((ctr + 1) > maxIndex)
                    break;

                value = values[ctr];
                nextValue = values[ctr + 1];

                if (value < nextValue)
                {
                    if (!increasingValues.Contains(value))
                        increasingValues.Add(value);
                    
                    if (!increasingValues.Contains(nextValue))
                        increasingValues.Add(nextValue);
                }

                DisplaySubIncreasingValues();

                ctr++;
            }
        }
    }
}
