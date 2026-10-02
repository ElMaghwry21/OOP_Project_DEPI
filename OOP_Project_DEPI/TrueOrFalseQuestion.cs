using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_DEPI
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string header, string body, int mark) : base(header, body, mark)
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1, "True");
            AnswerList[1] = new Answer(2, "False");
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header} (Mark: {Mark})");
            Console.WriteLine(Body);
            Console.WriteLine($"1. {AnswerList[0].AnswerText}  \t  2. {AnswerList[1].AnswerText}");
            Console.WriteLine("-----------------------------------");
        }
    }
}