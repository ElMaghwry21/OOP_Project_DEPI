using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_DEPI
{
    public abstract class Question : IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void ShowQuestion();

        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }
    }
}