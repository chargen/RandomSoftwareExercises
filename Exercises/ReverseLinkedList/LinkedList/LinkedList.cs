using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise4.LinkedList
{
    public class LinkedList
    {
        public int Value = 0;
        public LinkedList nextItem = null;

        public LinkedList(int pValue)
        {
            Value = pValue;
        }
    }
}
