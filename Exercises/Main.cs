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
            //RunExercise1();
            ////RunExercise2();  //TODO complete
            //RunExercise3();
            //RunExercise4();
            //RunExercise5();
            //RunExercise6();
            //RunExercise7();
            //RunExercise8();
            //RunExercise9();
            RunExercise10();
        }
        
        private void RunExercise1()
        {
            Exercise1.RotateArrayByOnePos e1 = new Exercise1.RotateArrayByOnePos();
            e1.Run();
        }
        private void RunExercise2()
        {
            Exercise2.SerializeTreeReconstruct e2 = new Exercise2.SerializeTreeReconstruct();
            e2.Run();
        }
        private void RunExercise3()
        {
            Exercise3.ReturnNthLargestElementFromArray e3 = new Exercise3.ReturnNthLargestElementFromArray();
            e3.Run();
        }
        private void RunExercise4()
        {
            Exercise4.ReverseLinkedList e4 = new Exercise4.ReverseLinkedList();
            e4.Run();
        }
        private void RunExercise5()
        {
            Exercise5.CalcSqrRtPerfectNonPerfectSquares e5 = new Exercise5.CalcSqrRtPerfectNonPerfectSquares();
            e5.Run();
        }
        private void RunExercise6()
        {
            Exercise6.ImplCustomSubstring e6 = new Exercise6.ImplCustomSubstring();
            e6.Run();
        }
        private void RunExercise7()
        {
            Exercise7.RvsWordsInSentence e7 = new Exercise7.RvsWordsInSentence();
            e7.Run();
        }
        private void RunExercise8()
        {
            Exercise8.CountNumOneBitsInInteger e8 = new Exercise8.CountNumOneBitsInInteger();
            e8.Run();
        }
        private void RunExercise9()
        {
            Exercise9.FindLgestSeqDescIncrInLargerSeq e9 = new Exercise9.FindLgestSeqDescIncrInLargerSeq();
            e9.Run();
        }
        private void RunExercise10()
        {
            Exercises.Matrix.Matrix m = new Exercises.Matrix.Matrix();
            m.RunTotals();
        }

    }
}
