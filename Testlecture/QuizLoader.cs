using System;
using System.Collections.Generic;
using System.IO;

namespace Testlecture
{
    internal static class QuizLoader
    {
        public static List<Question> LoadQuestions(string filePath)
        {
            var questions = new List<Question>();
            string[] lines = File.ReadAllLines(filePath);
            Question currentQuestion = null;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (line.StartsWith("Q:"))  // начало вопроса
                {
                    if (currentQuestion != null)
                        questions.Add(currentQuestion);

                    currentQuestion = new Question { Text = line.Substring(2).Trim(), Answers = new List<string>() };
                }
                else if (line.StartsWith("A:"))  // варианты ответов
                {
                    currentQuestion?.Answers.Add(line.Substring(2).Trim());
                }
                else if (line.StartsWith("C:"))  // индекс правильного ответа
                {
                    if (currentQuestion != null)
                        currentQuestion.CorrectAnswerIndex = Convert.ToInt32(line.Substring(2).Trim()) - 1;
                }
            }

            if (currentQuestion != null)
                questions.Add(currentQuestion);

            return questions;
        }
    }
}
