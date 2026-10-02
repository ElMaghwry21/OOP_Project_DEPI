using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_DEPI
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("========== Practical Exam ==========");
            int[] userAnswers = new int[QuestionsList.Length];

            for (int i = 0; i < QuestionsList.Length; i++)
            {
                QuestionsList[i].ShowQuestion();
                Console.Write("Enter your answer ID: ");
                userAnswers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine("\n--- Right Answers ---");
            for (int i = 0; i < QuestionsList.Length; i++)
            {
                Console.WriteLine($"Question ({QuestionsList[i].Body}): Right Answer is => {QuestionsList[i].RightAnswer.AnswerText}");
            }
        }
    }
}