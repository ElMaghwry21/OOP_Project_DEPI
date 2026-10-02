using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_DEPI
{
    public class Answer : ICloneable, IComparable<Answer>
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override string ToString()
        {
            return $"[{AnswerId}] {AnswerText}";
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }

        public int CompareTo(Answer other)
        {
            if (other == null) return 1;
            return this.AnswerId.CompareTo(other.AnswerId);
        }
    }
}