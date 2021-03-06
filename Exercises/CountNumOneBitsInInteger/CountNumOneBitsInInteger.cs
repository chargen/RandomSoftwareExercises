﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise8
{ 
    public class CountNumOneBitsInInteger
    {
        private int numberToCount1Bits = 82753;

        public CountNumOneBitsInInteger()
        {
            Console.WriteLine("Exercise 8:");
            Console.WriteLine("Counting the number of 1 bits in the binary representation of a given integer");            
        }        

        //TODO - try this is a less c#-ish way...something that could be used in other languages :)
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
