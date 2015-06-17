using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise8
{ 
    public class Exercise8
    {
        private int numberToCount1Bits = 82753;

        public Exercise8()
        {
            Console.WriteLine("Exercise 8:");
            Console.WriteLine("Counting the number of 1 bits in the binary representation of a given integer");            
        }        

        public void Run()
        {
            Console.WriteLine("Starting Exercise 8...");  

            Console.WriteLine("Number is " + numberToCount1Bits.ToString());

            string binaryView =  Convert.ToString(numberToCount1Bits, 2);
            char[] digits = binaryView.ToCharArray();
            
            Console.WriteLine("Binary version is " + binaryView);

            int ctr = 0;
            foreach(char digit in digits)
            {
                if (digit == '1')
                    ctr++;
            }

            Console.WriteLine("There are " + ctr.ToString() + " 1 bits in this number");

            Console.WriteLine("Exercise 8 is completed!");
        }
            
    }
}
