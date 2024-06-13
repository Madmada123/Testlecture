namespace Testlecture
{
    partial class EII
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
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.Lime;
            textBox1.Location = new Point(24, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1097, 381);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(508, 434);
            button1.Name = "button1";
            button1.Size = new Size(127, 60);
            button1.TabIndex = 1;
            button1.Text = "Открыть лекцию";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EII
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            ClientSize = new Size(1156, 506);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "EII";
            Text = "EII";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
    }
}