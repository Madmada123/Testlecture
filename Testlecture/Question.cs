using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlecture
{
    internal class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public List<Question> LoadQuestions(string filePath)
        {
            var questions = new List<Question>();
            string[] lines = File.ReadAllLines(filePath);
            Question question = null;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (line.StartsWith("Q:"))  // начало вопроса
                {
                    question = new Question { Text = line.Substring(2).Trim(), Answers = new List<string>() };
                    questions.Add(question);
                }
                else if (line.StartsWith("A:"))  // варианты ответов
                {
                    question?.Answers.Add(line.Substring(2).Trim());
                }
                else if (line.StartsWith("C:"))  // индекс правильного ответа
                {
                    if (question != null)
                        question.CorrectAnswerIndex = int.Parse(line.Substring(2).Trim()) - 1;  // предполагаем, что индексация начинается с 1
                }
            }

            return questions;
        }

    }
}
