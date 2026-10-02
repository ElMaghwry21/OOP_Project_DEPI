using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_DEPI
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Console.WriteLine("Enter 1 for Practical Exam or 2 for Final Exam:");
            int type = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Time of Exam (in minutes):");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number of Questions:");
            int numQ = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                SubjectExam = new PracticalExam(time, numQ);
            }
            else
            {
                SubjectExam = new FinalExam(time, numQ);
            }

            SubjectExam.QuestionsList = new Question[numQ];

            for (int i = 0; i < numQ; i++)
            {
                Console.WriteLine($"\n--- Details of Question {i + 1} ---");
                Console.WriteLine("Enter 1 for True/False or 2 for MCQ:");
                int qType = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Question Header:");
                string header = Console.ReadLine();

                Console.WriteLine("Enter Question Body:");
                string body = Console.ReadLine();

                Console.WriteLine("Enter Question Mark:");
                int mark = int.Parse(Console.ReadLine());

                if (qType == 1)
                {
                    TrueOrFalseQuestion tfQ = new TrueOrFalseQuestion(header, body, mark);

                    Console.WriteLine("Enter Right Answer ID (1 for True, 2 for False):");
                    int rightId = int.Parse(Console.ReadLine());
                    tfQ.RightAnswer = tfQ.AnswerList[rightId - 1];

                    SubjectExam.QuestionsList[i] = tfQ;
                }
                else
                {
                    MCQQuestion mcqQ = new MCQQuestion(header, body, mark);
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Enter choice {j + 1} text:");
                        string choiceText = Console.ReadLine();
                        mcqQ.AnswerList[j] = new Answer(j + 1, choiceText);
                    }

                    Console.WriteLine("Enter Right Answer ID (1, 2, or 3):");
                    int rightId = int.Parse(Console.ReadLine());
                    mcqQ.RightAnswer = mcqQ.AnswerList[rightId - 1];

                    SubjectExam.QuestionsList[i] = mcqQ;
                }
            }
        }
    }
}