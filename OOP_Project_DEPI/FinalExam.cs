using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_DEPI
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("========== Final Exam ==========");
            int totalGrade = 0;
            int studentGrade = 0;

            for (int i = 0; i < QuestionsList.Length; i++)
            {
                QuestionsList[i].ShowQuestion();
                Console.Write("Enter your answer ID: ");
                int userAnsId = int.Parse(Console.ReadLine());

                totalGrade += QuestionsList[i].Mark;
                if (QuestionsList[i].RightAnswer.AnswerId == userAnsId)
                {
                    studentGrade += QuestionsList[i].Mark;
                }
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine($"\nYour Grade is: {studentGrade} out of {totalGrade}");
        }
    }
}