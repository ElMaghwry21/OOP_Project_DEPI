using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_DEPI
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] QuestionsList { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            TimeOfExam = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();

        public object Clone()
        {
            // نسخ مبدئي للامتحان
            return this.MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            return this.TimeOfExam.CompareTo(other.TimeOfExam);
        }
    }
}