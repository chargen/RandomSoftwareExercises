using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise5
{
    //Perfect square is the square of two equal integers (i.e. 3*3 = 9).  
    public class CalcSqrRtPerfectNonPerfectSquares
    {
        public CalcSqrRtPerfectNonPerfectSquares()
        {
            Console.WriteLine("Exercise 5:");
            Console.WriteLine("Algorithm to compute square root that handles perfect and non-perfect squares");            
        }
        

        public void Run()
        {
            int curValue = 1;
            double remainder = 0;

            Console.WriteLine("Starting Exercise 5...");  
            
            while(curValue<= 200)
            {
                double val = Math.Sqrt(curValue);
                remainder = val % (double)Convert.ToInt32(val);
                
                Console.WriteLine("Value is : " + curValue);                
                Console.WriteLine("Square root is : " + val);

                if (remainder == 0)             
                    Console.WriteLine("Value is a perfect square");
                else
                    Console.WriteLine("Value is not a perfect square");
                
                Console.WriteLine("");

                curValue++;
            }
        
            Console.WriteLine("Exercise 5 is completed!");
        }
    }
}
