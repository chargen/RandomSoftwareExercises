using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise7
{ 
    public class Exercise7
    {
        private string sentence = "A very long sentence that doesn't really say anything about much.  It has to be understood and if reversed, I am not sure it will.";
        private string reversedSentence = string.Empty;

        public Exercise7()
        {
            Console.WriteLine("Exercise 7:");
            Console.WriteLine("Reverse the words in the sentence");            
        }        

        public void Run()
        {
            Console.WriteLine("Starting Exercise 7...");  

            Console.WriteLine("Sentence:");
            Console.WriteLine(sentence);

            ReverseSentence1();
            
            Console.WriteLine("Sentence:");
            Console.WriteLine(sentence);
            ReverseSentence2();

            Console.WriteLine("Exercise 6 is completed!");
        }
        
        private void ReverseSentence2()
        {
            char[] sentenceChar = sentence.ToCharArray();
            char[] reversedSentenceChar = new char[sentenceChar.Length + 1];
            int reverseCtr = sentenceChar.Length;

            foreach(char character in sentenceChar)
            {
                reversedSentenceChar[reverseCtr] = character;
                reverseCtr--;
            }
            
            string reversedSentence = new string(reversedSentenceChar);
            reversedSentence = reversedSentence.Replace("\0","");
            Console.WriteLine("Reversed Sentence: ");
            Console.WriteLine(reversedSentence);
        }
        private void ReverseSentence1()
        {
            StringBuilder sb = new StringBuilder();
            string[] sentenceParts = sentence.Split(' ');
            int ctr = 0;
            int reverseCntr = sentenceParts.Length-1;

            while (ctr < sentenceParts.Length-1)
            {
                sb.Append(sentenceParts[reverseCntr] + " ");

                reverseCntr--;
                ctr++;
            }           

            Console.WriteLine("Reversed Sentence: ");
            Console.WriteLine(sb.ToString());
        }
    }
}
