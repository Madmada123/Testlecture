namespace Testlecture
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblQuestion = new Label();
            btnAnswer1 = new Button();
            btnAnswer2 = new Button();
            btnAnswer3 = new Button();
            btnAnswer4 = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.icons8_назад_80;
            button1.Location = new Point(34, 31);
            button1.Name = "button1";
            button1.Size = new Size(127, 97);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblQuestion
            // 
            lblQuestion.Anchor = AnchorStyles.None;
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Black;
            lblQuestion.ForeColor = Color.Yellow;
            lblQuestion.Location = new Point(366, 154);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(50, 20);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "label1";
            // 
            // btnAnswer1
            // 
            btnAnswer1.Anchor = AnchorStyles.None;
            btnAnswer1.BackColor = Color.Black;
            btnAnswer1.FlatStyle = FlatStyle.Flat;
            btnAnswer1.ForeColor = Color.Red;
            btnAnswer1.Location = new Point(366, 256);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(94, 29);
            btnAnswer1.TabIndex = 2;
            btnAnswer1.Text = "button2";
            btnAnswer1.UseVisualStyleBackColor = false;
            btnAnswer1.Click += btnAnswer_Click;
            // 
            // btnAnswer2
            // 
            btnAnswer2.Anchor = AnchorStyles.None;
            btnAnswer2.BackColor = Color.Black;
            btnAnswer2.FlatStyle = FlatStyle.Flat;
            btnAnswer2.ForeColor = Color.Red;
            btnAnswer2.Location = new Point(534, 256);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(94, 29);
            btnAnswer2.TabIndex = 3;
            btnAnswer2.Text = "button3";
            btnAnswer2.UseVisualStyleBackColor = false;
            btnAnswer2.Click += btnAnswer_Click;
            // 
            // btnAnswer3
            // 
            btnAnswer3.Anchor = AnchorStyles.None;
            btnAnswer3.BackColor = Color.Black;
            btnAnswer3.FlatStyle = FlatStyle.Flat;
            btnAnswer3.ForeColor = Color.Red;
            btnAnswer3.Location = new Point(681, 256);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(94, 29);
            btnAnswer3.TabIndex = 4;
            btnAnswer3.Text = "button4";
            btnAnswer3.UseVisualStyleBackColor = false;
            btnAnswer3.Click += btnAnswer_Click;
            // 
            // btnAnswer4
            // 
            btnAnswer4.Anchor = AnchorStyles.None;
            btnAnswer4.BackColor = Color.Black;
            btnAnswer4.FlatStyle = FlatStyle.Flat;
            btnAnswer4.ForeColor = Color.Red;
            btnAnswer4.Location = new Point(843, 256);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(94, 29);
            btnAnswer4.TabIndex = 5;
            btnAnswer4.Text = "button5";
            btnAnswer4.UseVisualStyleBackColor = false;
            btnAnswer4.Click += btnAnswer_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.None;
            btnPrevious.BackColor = Color.Black;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.ForeColor = Color.Lime;
            btnPrevious.Location = new Point(490, 333);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(105, 65);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "Назад";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.Black;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.Lime;
            btnNext.Location = new Point(655, 333);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 65);
            btnNext.TabIndex = 7;
            btnNext.Text = "Вперед";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(385, 20);
            label1.Name = "label1";
            label1.Size = new Size(457, 54);
            label1.TabIndex = 8;
            label1.Text = "Интерактивная задания";
            // 
            // Form3
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            ClientSize = new Size(1124, 470);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnAnswer4);
            Controls.Add(btnAnswer3);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer1);
            Controls.Add(lblQuestion);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label lblQuestion;
        private Button btnAnswer1;
        private Button btnAnswer2;
        private Button btnAnswer3;
        private Button btnAnswer4;
        private Button btnPrevious;
        private Button btnNext;
        private Label label1;
    }
}