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
    public partial class Form3 : Form
    {


        private List<Question> questions = new List<Question>(); // Список для хранения вопросов
        private int questionIndex = 0;
        private int correctAnswersCount = 0;  // Счетчик правильных ответов



        public Form3()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            InitializeQuestions();
            DisplayQuestion(questionIndex);
            // Настройка Drag and Drop
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form3_DragEnter);
            this.DragDrop += new DragEventHandler(Form3_DragDrop);
        }


        private void Form3_DragEnter(object sender, DragEventArgs e)
        {
            // Проверяем, что перетаскиваемые данные содержат файл
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // Разрешаем копирование
            }
            else
            {
                e.Effect = DragDropEffects.None; // Не разрешаем другие действия
            }
        }
        private void Form3_DragDrop(object sender, DragEventArgs e)
        {
            // Получаем все файлы, которые были перетащены в форму
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length > 0)
            {
                LoadQuestionsFromFile(files[0]); // Загружаем вопросы из первого перетаскиваемого файла
                if (questions.Count > 0)
                {
                    questionIndex = 0;
                    DisplayQuestion(questionIndex);
                }
                else
                {
                    MessageBox.Show("Вопросы из файла не были загружены.");
                }
            }
        }

        private void InitializeQuestions()
        {

            // Пример добавления вопросов
            questions.Add(new Question
            {
                Text = "С мышкой принеси вопросы в формате тхт прямо сюда",
                Answers = new List<Answer>
            {
                new Answer { Text = "Понял", IsCorrect = true },
                new Answer { Text = "Нет", IsCorrect = false },
                new Answer { Text = "ААА", IsCorrect = false }
            }
            });

            // Добавьте больше вопросов по аналогии
        }
        private void LoadQuestionsFromFile(string filePath)
        {
            questions.Clear(); // Очистка текущего списка вопросов
            string[] lines = File.ReadAllLines(filePath); // Чтение всех строк файла
            Question question = null;

            foreach (string line in lines)
            {
                Console.WriteLine($"Считанная строка: {line}"); // Для отладки
                if (string.IsNullOrWhiteSpace(line))
                    continue; // Пропускаем пустые строки

                if (line.EndsWith("?")) // Это вопрос
                {
                    question = new Question { Text = line, Answers = new List<Answer>() };
                    questions.Add(question);
                }
                else if (line.StartsWith("*")) // Это правильный ответ
                {
                    if (question != null)
                    {
                        question.Answers.Add(new Answer { Text = line.Substring(1), IsCorrect = true });
                    }
                }
                else // Это неправильный ответ
                {
                    if (question != null)
                    {
                        question.Answers.Add(new Answer { Text = line, IsCorrect = false });
                    }
                }
            }

            Console.WriteLine($"Всего загружено вопросов: {questions.Count}"); // Для отладки
            if (questions.Count > 0)
            {
                questionIndex = 0;
                DisplayQuestion(questionIndex);
            }
        }


        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadQuestionsFromFile(openFileDialog1.FileName);
                if (questions.Count > 0) // Проверяем, загружены ли вопросы
                {
                    questionIndex = 0; // Сброс индекса вопроса
                    DisplayQuestion(questionIndex); // Отображаем первый вопрос
                }
                else
                {
                    MessageBox.Show("Вопросы из файла не были загружены.");
                }
            }
        }



        public class Question
        {
            public string Text { get; set; }
            public List<Answer> Answers { get; set; }
        }

        public class Answer
        {
            public string Text { get; set; }
            public bool IsCorrect { get; set; }
        }

        private void InitializeOpenFileDialog()
        {
            // Установка начальной директории для OpenFileDialog
            // Path.Combine() используется для создания пути, который корректно работает на разных операционных системах.
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory; // Получает базовую директорию исполняемого файла
            string initialDirectory = Path.Combine(projectDirectory, @"Test\"); // Папка Test должна находиться в директории проекта

            openFileDialog1.InitialDirectory = initialDirectory;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        }




        // Пример метода для отображения задания
        void DisplayQuestion(int index)
        {
            var question = questions[index]; // Получение текущего вопроса
            lblQuestion.Text = question.Text;
            btnAnswer1.Text = question.Answers[0].Text;
            btnAnswer1.Tag = question.Answers[0].IsCorrect;
            btnAnswer2.Text = question.Answers[1].Text;
            btnAnswer2.Tag = question.Answers[1].IsCorrect;
            btnAnswer3.Text = question.Answers[2].Text;
            btnAnswer3.Tag = question.Answers[2].IsCorrect;
            // Повторите для других кнопок, если необходимо
        }

        // Пример обработчика событий для кнопок
        void btnAnswer_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                bool isCorrect = (bool)clickedButton.Tag;
                if (isCorrect)
                {
                    correctAnswersCount++;  // Увеличиваем счетчик, если ответ правильный
                    MessageBox.Show("Правильно!");
                }
                else
                {
                    MessageBox.Show("Неправильно!");
                }

                // Проверяем, есть ли еще вопросы
                if (questionIndex < questions.Count - 1)
                {
                    questionIndex++;
                    DisplayQuestion(questionIndex);
                }
                else
                {
                    // В конце теста выводим количество правильных ответов
                    MessageBox.Show($"Вы правильно ответили на {correctAnswersCount} из {questions.Count} вопросов.");
                    correctAnswersCount = 0; // Сбрасываем счетчик для нового теста
                }
            }
        }


        private void ParseQuestions(string content)
        {
            var questions = content.Split(new[] { "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            MessageBox.Show("Количество вопросов: " + questions.Length);  // Отладочный вывод
            if (questions.Length > 0)
            {
                ShowQuestion(questions[0]);  // Показать первый вопрос
            }
        }



        private void ShowQuestion(string question)
        {
            var parts = question.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Проверяемый вопрос: " + question); // Для диагностики
            MessageBox.Show("Количество частей: " + parts.Length); // Для диагностики
            if (parts.Length >= 4)
            {
                lblQuestion.Text = parts[0]; // Вопрос
                btnAnswer1.Text = parts[1].Trim('*');  // Первый ответ
                btnAnswer2.Text = parts[2].Trim('*');  // Второй ответ
                btnAnswer3.Text = parts[3].Trim('*');  // Третий ответ
            }

            else
            {
                MessageBox.Show("Недостаточно данных в вопросе. Проверьте формат файла.");
            }
        }

        private void CheckAnswer(string chosenAnswer)
        {
            // Проверка ответа
            MessageBox.Show("Ваш ответ " + chosenAnswer + " правильный/неправильный.");
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        int currentQuestionIndex = 0; // Индекс текущего вопроса





        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2Form = new Form2();
            Form2Form.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (questionIndex < questions.Count - 1) // Проверка на последний вопрос
            {
                questionIndex++; // Инкремент
                DisplayQuestion(questionIndex);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (questionIndex > 0) // Используйте questionIndex
            {
                questionIndex--; // Декремент
                DisplayQuestion(questionIndex);
            }
        }
    }
}
