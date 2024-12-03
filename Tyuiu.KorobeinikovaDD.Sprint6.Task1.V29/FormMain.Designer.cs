namespace Tyuiu.KorobeinikovaDD.Sprint6.Task1.V29
{
    partial class FormMain
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
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textboxST
            // 
            textboxST.Location = new Point(7, 57);
            textboxST.Multiline = true;
            textboxST.Name = "textboxST";
            textboxST.Size = new Size(158, 44);
            textboxST.TabIndex = 0;
            // 
            // textboxEND
            // 
            textboxEND.Location = new Point(187, 57);
            textboxEND.Multiline = true;
            textboxEND.Name = "textboxEND";
            textboxEND.Size = new Size(155, 44);
            textboxEND.TabIndex = 1;
            // 
            // Tablica
            // 
            Tablica.Location = new Point(0, 54);
            Tablica.Multiline = true;
            Tablica.Name = "Tablica";
            Tablica.Size = new Size(273, 367);
            Tablica.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Старт шага:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 34);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Конец шага:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
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
            label5.Location = new Point(177, 190);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_11_24_03_31_04;
            pictureBox1.Location = new Point(0, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 52);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 32);
            label6.Name = "label6";
            label6.Size = new Size(453, 20);
            label6.TabIndex = 9;
            label6.Text = "Вывести таблицу значений функций на заданном отрезке [-5,5]\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(505, 374);
            button1.Name = "button1";
            button1.Size = new Size(168, 64);
            button1.TabIndex = 10;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonDone_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(803, 46);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Location = new Point(389, 374);
            button2.Name = "button2";
            button2.Size = new Size(110, 64);
            button2.TabIndex = 12;
            button2.Text = "Справка";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonHelp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 119);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Tablica);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(679, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 418);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textboxST);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textboxEND);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 329);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 109);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            MinimumSize = new Size(1000, 500);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 29 | Коробейникова Д.Д.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
