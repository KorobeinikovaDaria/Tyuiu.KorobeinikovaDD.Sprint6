namespace Tyuiu.KorobeinikovaDD.Sprint6.Task1.V29
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
            textboxST = new TextBox();
            textboxEND = new TextBox();
            Tablica = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textboxST
            // 
            textboxST.Location = new Point(32, 257);
            textboxST.Multiline = true;
            textboxST.Name = "textboxST";
            textboxST.Size = new Size(158, 44);
            textboxST.TabIndex = 0;
            // 
            // textboxEND
            // 
            textboxEND.Location = new Point(280, 257);
            textboxEND.Multiline = true;
            textboxEND.Name = "textboxEND";
            textboxEND.Size = new Size(155, 44);
            textboxEND.TabIndex = 1;
            // 
            // Tablica
            // 
            Tablica.Location = new Point(501, 46);
            Tablica.Multiline = true;
            Tablica.Name = "Tablica";
            Tablica.Size = new Size(267, 367);
            Tablica.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 234);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Старт шага:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 234);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Конец шага:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 23);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Результат:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 9);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 199);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 7;
            label5.Text = "Ввод данных:";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_11_24_03_31_04;
            pictureBox1.Location = new Point(32, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 52);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 56);
            label6.Name = "label6";
            label6.Size = new Size(453, 20);
            label6.TabIndex = 9;
            label6.Text = "Вывести таблицу значений функций на заданном отрезке [-5,5]\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(151, 349);
            button1.Name = "button1";
            button1.Size = new Size(159, 64);
            button1.TabIndex = 10;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonDone_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 23);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 11;
            label7.Text = "Условие:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Tablica);
            Controls.Add(textboxEND);
            Controls.Add(textboxST);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxST;
        private TextBox textboxEND;
        private TextBox Tablica;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Button button1;
        private Label label7;
    }
}
