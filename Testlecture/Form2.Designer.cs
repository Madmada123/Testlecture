namespace Testlecture
{
    partial class Form2
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
            Back = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = Color.Black;
            Back.FlatStyle = FlatStyle.Popup;
            Back.Image = Properties.Resources.icons8_назад_80;
            Back.Location = new Point(40, 26);
            Back.Name = "Back";
            Back.Size = new Size(155, 129);
            Back.TabIndex = 0;
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Image = Properties.Resources.icons8_квадрат_100;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(238, 182);
            button1.Name = "button1";
            button1.Size = new Size(200, 168);
            button1.TabIndex = 1;
            button1.Text = "Легкий";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Lime;
            button2.Image = Properties.Resources.icons8_куб_100;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(478, 182);
            button2.Name = "button2";
            button2.Size = new Size(200, 168);
            button2.TabIndex = 2;
            button2.Text = "Средний";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Lime;
            button3.Image = Properties.Resources.icons8_tesseract_1001;
            button3.ImageAlign = ContentAlignment.BottomCenter;
            button3.Location = new Point(714, 182);
            button3.Name = "button3";
            button3.Size = new Size(200, 168);
            button3.TabIndex = 3;
            button3.Text = "Сложный";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Black;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = Properties.Resources.icons8_длинная_стрелка_вправо_80;
            button4.Location = new Point(1013, 182);
            button4.Name = "button4";
            button4.Size = new Size(94, 166);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(317, 46);
            label1.Name = "label1";
            label1.Size = new Size(551, 62);
            label1.TabIndex = 5;
            label1.Text = "ВЫБЕРИТЕ СЛОЖНОСТЬ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            ClientSize = new Size(1129, 492);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Back);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}