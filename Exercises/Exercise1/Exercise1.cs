using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise1
{
    public class Exercise1
    {
        private IList<int> values = null;
        private IList<int> modifiedValues = null;

        public Exercise1()
        {
            Console.WriteLine("Exercise 1:");
            Console.WriteLine("Rotate an array of ints by 1");
            values = PopulateValues();
            modifiedValues = PopulateValues();
        }

        private IList<int> PopulateValues()
        {
            IList<int> values = new List<int>();

            values.Add(1);
            values.Add(2);
            values.Add(3);
            values.Add(4);
            values.Add(5);
            values.Add(6);
            values.Add(7);
            values.Add(8);
            values.Add(9);
            values.Add(10);

            return values;
        }

        public void Run()
        {
            Console.WriteLine("Starting Exercise 1...");

            DisplayValues();

            RotateArrayBy1();

            DisplayValues();
            
            Console.WriteLine("Exercise 1 is completed!");
        }

        private void DisplayValues()
        {
            foreach(int value in modifiedValues)
                Console.WriteLine(value.ToString());
            
            Console.WriteLine("");
        }

        private void RotateArrayBy1()
        {
            if (values.Count()>0)
            {
                int tmpValue = values[0];
                int ctr = 0;

                foreach(int value in values)
                {
                    if (ctr>=(values.Count()-1))
                        modifiedValues[ctr] = tmpValue;
                    else             
                        modifiedValues[ctr] = values[ctr+1];

                    DisplayValues();

                    ctr++;
                }
            }
        }
    }
}
