using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testlecture
{
    public partial class H6 : Form
    {
        public H6()
        {
            InitializeComponent();
        }
        private List<int> userAnswers;
        private int currentQuestionIndex = 0;
        private List<Question> questions;

        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                groupBox1.Text = question.Text;
                radioButton1.Text = question.Answers[0];
                radioButton2.Text = question.Answers[1];
                radioButton3.Text = question.Answers[2];
                radioButton4.Text = question.Answers[3];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Сохраняем выбранный ответ перед увеличением индекса
            if (radioButton1.Checked) userAnswers[currentQuestionIndex] = 0;
            else if (radioButton2.Checked) userAnswers[currentQuestionIndex] = 1;
            else if (radioButton3.Checked) userAnswers[currentQuestionIndex] = 2;
            else if (radioButton4.Checked) userAnswers[currentQuestionIndex] = 3;

            // Проверяем, есть ли еще вопросы
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayCurrentQuestion();
            }
            else
            {
                ShowResults();
            }
        }

        private void H6_Load(object sender, EventArgs e)
        {
            questions = QuizLoader.LoadQuestions("Test\\H6.txt");
            userAnswers = new List<int>(new int[questions.Count]); // Создаем список с размером количества вопросов
            DisplayCurrentQuestion();

            questions = QuizLoader.LoadQuestions("Test\\H6.txt");
            if (questions.Count == 0)
            {
                MessageBox.Show("В файле нет вопросов.");
                return; // Заканчиваем выполнение, если вопросов нет
            }
            userAnswers = new List<int>(new int[questions.Count]);
            DisplayCurrentQuestion();
        }
        private List<Question> LoadQuestions(string filePath)
        {
            var questions = new List<Question>();
            var lines = File.ReadAllLines(filePath);
            Question currentQuestion = null;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (line.StartsWith("Q:"))
                {
                    if (currentQuestion != null)
                        questions.Add(currentQuestion);

                    currentQuestion = new Question
                    {
                        Text = line.Substring(2).Trim(),
                        Answers = new List<string>()
                    };
                }
                else if (line.StartsWith("A:"))
                {
                    currentQuestion?.Answers.Add(line.Substring(2).Trim());
                }
                else if (line.StartsWith("C:"))
                {
                    if (currentQuestion != null)
                        currentQuestion.CorrectAnswerIndex = Convert.ToInt32(line.Substring(2).Trim()) - 1;
                }
            }

            if (currentQuestion != null)
                questions.Add(currentQuestion);

            return questions;
        }
        private void ShowResults()
        {
            int correctAnswers = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (userAnswers[i] == questions[i].CorrectAnswerIndex + 1) // +1 потому что индексация ответов начинается с 1
                {
                    correctAnswers++;
                }
            }

            MessageBox.Show("Вы ответили правильно на " + correctAnswers + " из " + questions.Count + " вопросов.");
        }
    }
}
