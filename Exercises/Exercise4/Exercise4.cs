using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Exercises.Exercise4.LinkedList;

namespace Exercises.Exercise4
{
    public class Exercise4
    {
        private Exercises.Exercise4.LinkedList.LinkedList firstNode = null;

        public Exercise4()
        {
            Console.WriteLine("Exercise 4:");
            Console.WriteLine("Reverse a LinkedList");
            firstNode = PopulateValues();
        }

        private Exercises.Exercise4.LinkedList.LinkedList PopulateValues()
        {
            var ll1 = new Exercises.Exercise4.LinkedList.LinkedList(1);
            var ll2 = new Exercises.Exercise4.LinkedList.LinkedList(2);
            var ll3 = new Exercises.Exercise4.LinkedList.LinkedList(3);
            var ll4 = new Exercises.Exercise4.LinkedList.LinkedList(4);
            var ll5 = new Exercises.Exercise4.LinkedList.LinkedList(5);

            ll1.nextItem = ll2;
            ll2.nextItem = ll3;
            ll3.nextItem = ll4;
            ll4.nextItem = ll5;

            return ll1;
        }

        public void Run()
        {
            Console.WriteLine("Starting Exercise 4...");  

            Exercises.Exercise4.LinkedList.LinkedList node = null;

            System.Collections.Stack s = new System.Collections.Stack();
                        
            s.Push(firstNode);
            node = firstNode.nextItem; 

            while(node != null)
            {                           
                s.Push(node);
                node = node.nextItem;
            }
                        
            firstNode = (Exercises.Exercise4.LinkedList.LinkedList)s.Pop();
            node = firstNode;
            while(s.Count>0)
            {
                node.nextItem = (Exercises.Exercise4.LinkedList.LinkedList)s.Pop();
                node = node.nextItem;
            }
            
            Console.WriteLine("Exercise 4 is completed!");
        }
    }
}
