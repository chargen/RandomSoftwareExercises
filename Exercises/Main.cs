using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Main
    {
        public void Run()
        {
            RunExercise1();
            RunExercise2();
        }

        private void RunExercise1()
        {
            Exercise1.Exercise1 e1 = new Exercise1.Exercise1();
            e1.Run();
        }

        private void RunExercise2()
        {
            Exercise2.Exercise2 e2 = new Exercise2.Exercise2();
            e2.Run();
        }
    }
}
