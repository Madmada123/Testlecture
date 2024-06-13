namespace Testlecture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            IKT = new Button();
            EII = new Button();
            KOMP = new Button();
            SS = new Button();
            GRAF = new Button();
            DATAPRO = new Button();
            NEXT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(348, 61);
            label1.Name = "label1";
            label1.Size = new Size(323, 54);
            label1.TabIndex = 0;
            label1.Text = "ВЫБОР ЛЕКЦИИ";
            // 
            // IKT
            // 
            IKT.Anchor = AnchorStyles.None;
            IKT.BackColor = Color.Black;
            IKT.Cursor = Cursors.Hand;
            IKT.FlatAppearance.BorderColor = Color.Lime;
            IKT.FlatAppearance.BorderSize = 5;
            IKT.FlatStyle = FlatStyle.Flat;
            IKT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            IKT.ForeColor = Color.Lime;
            IKT.Image = Properties.Resources.icons8_смартфон_64;
            IKT.ImageAlign = ContentAlignment.BottomCenter;
            IKT.Location = new Point(253, 151);
            IKT.Name = "IKT";
            IKT.Size = new Size(150, 150);
            IKT.TabIndex = 1;
            IKT.Text = "Основные устройства ИКТ";
            IKT.TextAlign = ContentAlignment.TopCenter;
            IKT.UseVisualStyleBackColor = false;
            IKT.Click += IKT_Click;
            // 
            // EII
            // 
            EII.Anchor = AnchorStyles.None;
            EII.BackColor = Color.Black;
            EII.Cursor = Cursors.Hand;
            EII.FlatAppearance.BorderColor = Color.Lime;
            EII.FlatAppearance.BorderSize = 5;
            EII.FlatStyle = FlatStyle.Flat;
            EII.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EII.ForeColor = Color.Lime;
            EII.Image = Properties.Resources.icons8_four_squares_50;
            EII.ImageAlign = ContentAlignment.BottomCenter;
            EII.Location = new Point(433, 151);
            EII.Name = "EII";
            EII.Size = new Size(150, 150);
            EII.TabIndex = 2;
            EII.Text = "Единицы измерения информации ";
            EII.TextAlign = ContentAlignment.TopCenter;
            EII.UseVisualStyleBackColor = false;
            EII.Click += EII_Click;
            // 
            // KOMP
            // 
            KOMP.Anchor = AnchorStyles.None;
            KOMP.BackColor = Color.Black;
            KOMP.Cursor = Cursors.Hand;
            KOMP.FlatAppearance.BorderColor = Color.Lime;
            KOMP.FlatAppearance.BorderSize = 5;
            KOMP.FlatStyle = FlatStyle.Flat;
            KOMP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            KOMP.ForeColor = Color.Lime;
            KOMP.Image = Properties.Resources.icons8_домен_50;
            KOMP.ImageAlign = ContentAlignment.BottomCenter;
            KOMP.Location = new Point(609, 151);
            KOMP.Name = "KOMP";
            KOMP.Size = new Size(150, 150);
            KOMP.TabIndex = 3;
            KOMP.Text = "Компьютерные сети и интернет ";
            KOMP.TextAlign = ContentAlignment.TopCenter;
            KOMP.UseVisualStyleBackColor = false;
            KOMP.Click += KOMP_Click;
            // 
            // SS
            // 
            SS.Anchor = AnchorStyles.None;
            SS.BackColor = Color.Black;
            SS.Cursor = Cursors.Hand;
            SS.FlatAppearance.BorderColor = Color.Lime;
            SS.FlatAppearance.BorderSize = 5;
            SS.FlatStyle = FlatStyle.Flat;
            SS.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SS.ForeColor = Color.Lime;
            SS.Image = (Image)resources.GetObject("SS.Image");
            SS.ImageAlign = ContentAlignment.BottomCenter;
            SS.Location = new Point(253, 345);
            SS.Name = "SS";
            SS.Size = new Size(150, 150);
            SS.TabIndex = 4;
            SS.Text = "Системы счисления";
            SS.TextAlign = ContentAlignment.TopCenter;
            SS.UseVisualStyleBackColor = false;
            SS.Click += SS_Click;
            // 
            // GRAF
            // 
            GRAF.Anchor = AnchorStyles.None;
            GRAF.BackColor = Color.Black;
            GRAF.Cursor = Cursors.Hand;
            GRAF.FlatAppearance.BorderColor = Color.Lime;
            GRAF.FlatAppearance.BorderSize = 5;
            GRAF.FlatStyle = FlatStyle.Flat;
            GRAF.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            GRAF.ForeColor = Color.Lime;
            GRAF.Image = Properties.Resources.icons8_network_100;
            GRAF.ImageAlign = ContentAlignment.BottomCenter;
            GRAF.Location = new Point(433, 345);
            GRAF.Name = "GRAF";
            GRAF.Size = new Size(150, 150);
            GRAF.TabIndex = 5;
            GRAF.Text = "Графы";
            GRAF.TextAlign = ContentAlignment.TopCenter;
            GRAF.UseVisualStyleBackColor = false;
            GRAF.Click += GRAF_Click;
            // 
            // DATAPRO
            // 
            DATAPRO.Anchor = AnchorStyles.None;
            DATAPRO.BackColor = Color.Black;
            DATAPRO.Cursor = Cursors.Hand;
            DATAPRO.FlatAppearance.BorderColor = Color.Lime;
            DATAPRO.FlatAppearance.BorderSize = 5;
            DATAPRO.FlatStyle = FlatStyle.Flat;
            DATAPRO.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DATAPRO.ForeColor = Color.Lime;
            DATAPRO.Image = Properties.Resources.icons8_поиск_по_базам_данных_501;
            DATAPRO.ImageAlign = ContentAlignment.BottomCenter;
            DATAPRO.Location = new Point(609, 345);
            DATAPRO.Name = "DATAPRO";
            DATAPRO.Size = new Size(150, 150);
            DATAPRO.TabIndex = 6;
            DATAPRO.Text = "Обработка данных";
            DATAPRO.TextAlign = ContentAlignment.TopCenter;
            DATAPRO.UseVisualStyleBackColor = false;
            DATAPRO.Click += DATAPRO_Click;
            // 
            // NEXT
            // 
            NEXT.Anchor = AnchorStyles.None;
            NEXT.BackColor = Color.Black;
            NEXT.FlatAppearance.BorderColor = Color.Lime;
            NEXT.FlatAppearance.BorderSize = 5;
            NEXT.FlatStyle = FlatStyle.Popup;
            NEXT.Image = Properties.Resources.icons8_длинная_стрелка_вправо_100;
            NEXT.Location = new Point(909, 206);
            NEXT.Name = "NEXT";
            NEXT.Size = new Size(122, 186);
            NEXT.TabIndex = 7;
            NEXT.UseVisualStyleBackColor = false;
            NEXT.Click += NEXT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            ClientSize = new Size(1043, 514);
            Controls.Add(NEXT);
            Controls.Add(DATAPRO);
            Controls.Add(GRAF);
            Controls.Add(SS);
            Controls.Add(KOMP);
            Controls.Add(EII);
            Controls.Add(IKT);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button IKT;
        private Button EII;
        private Button KOMP;
        private Button SS;
        private Button GRAF;
        private Button DATAPRO;
        private Button NEXT;
    }
}