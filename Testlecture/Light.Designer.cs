namespace Testlecture
{
    partial class Light
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(206, 113);
            button1.Name = "button1";
            button1.Size = new Size(166, 127);
            button1.TabIndex = 0;
            button1.Text = "#Test1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(409, 113);
            button2.Name = "button2";
            button2.Size = new Size(166, 127);
            button2.TabIndex = 1;
            button2.Text = "#Test2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(612, 113);
            button3.Name = "button3";
            button3.Size = new Size(166, 127);
            button3.TabIndex = 2;
            button3.Text = "#Test3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(206, 277);
            button4.Name = "button4";
            button4.Size = new Size(166, 127);
            button4.TabIndex = 3;
            button4.Text = "#Test4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(409, 277);
            button5.Name = "button5";
            button5.Size = new Size(166, 127);
            button5.TabIndex = 4;
            button5.Text = "#Test5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(612, 277);
            button6.Name = "button6";
            button6.Size = new Size(166, 127);
            button6.TabIndex = 5;
            button6.Text = "#Test6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Light
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            ClientSize = new Size(1132, 488);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.Lime;
            Name = "Light";
            Text = "Light";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}