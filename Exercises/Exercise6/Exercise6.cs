﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise6
{ 
    public class Exercise6
    {
        private string valueToSearch = "123456789";
        private string srchValue = "456";

        public Exercise6()
        {
            Console.WriteLine("Exercise 6:");
            Console.WriteLine("Implement custom substring");            
        }        

        public void Run()
        {
            Console.WriteLine("Starting Exercise 6...");  
            
            bool allCharactersMatch = true;
            char[] characters = valueToSearch.ToCharArray();
            char[] srchChar = this.srchValue.ToCharArray();
            char[] chrCharList = new char[srchChar.Length];
            string curVal = string.Empty;
            int outerCtr = 0;
            int maxInteractionCnt = characters.Length-srchChar.Length;
            
            while(outerCtr <= maxInteractionCnt)
            {
                int innerCtr = 0;
                allCharactersMatch = true;

                while(innerCtr < srchChar.Length)
                {
                    int characterIndex = innerCtr + outerCtr;
                    chrCharList[innerCtr] = characters[characterIndex];
                    innerCtr++;
                }
                
                innerCtr = 0;
                while(innerCtr < srchChar.Length)
                {
                    if (chrCharList[innerCtr] != srchChar[innerCtr])
                    {
                        allCharactersMatch = false;
                        break;
                    }

                    innerCtr++;
                }

                if (allCharactersMatch)
                    break;

                outerCtr++;
            }

            if (allCharactersMatch)
                Console.WriteLine("Match found");
            else
                Console.WriteLine("Match not found");

            Console.WriteLine("Exercise 6 is completed!");
        }
    }
}
