using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace Testlecture
{
    public partial class DATA : Form
    {
        public DATA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Путь к файлу внутри папки проекта, папка Lecture должна быть внутри папки Debug/Release
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lecture", "Обработка данных.docx");
            LoadDocxFile(filePath);

        }
        private void LoadDocxFile(string filePath)
        {
            try
            {
                // Загружаем документ
                using (DocX document = DocX.Load(filePath))
                {
                    // Отображаем текст документа в textBox1
                    textBox1.Text = document.Text;
                }
            }
            catch (Exception ex)
            {
                // Если файл не найден или другая ошибка, выводим сообщение
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
