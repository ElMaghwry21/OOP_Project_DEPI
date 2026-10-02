using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_DEPI
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark) : base(header, body, mark)
        {
            AnswerList = new Answer[3]; // 3 اختيارات كمثال
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header} (Mark: {Mark})");
            Console.WriteLine(Body);
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine($"{AnswerList[i].AnswerId}. {AnswerList[i].AnswerText}");
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}