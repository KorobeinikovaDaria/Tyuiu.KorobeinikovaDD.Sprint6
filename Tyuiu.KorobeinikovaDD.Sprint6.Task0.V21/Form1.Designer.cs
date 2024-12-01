namespace Tyuiu.KorobeinikovaDD.Sprint6.Task0.V21
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
            label1 = new Label();
            textBoxVarA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxResult = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // textBoxVarA
            // 
            textBoxVarA.Location = new Point(34, 307);
            textBoxVarA.Multiline = true;
            textBoxVarA.Name = "textBoxVarA";
            textBoxVarA.Size = new Size(167, 51);
            textBoxVarA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 284);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите значение х:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 284);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(480, 307);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(247, 51);
            textBoxResult.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(480, 364);
            button2.Name = "button2";
            button2.Size = new Size(190, 51);
            button2.TabIndex = 6;
            button2.Text = "Вычислить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonDone_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_11_24_03_33_11;
            pictureBox1.Location = new Point(34, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 62);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 63);
            label4.Name = "label4";
            label4.Size = new Size(245, 20);
            label4.TabIndex = 8;
            label4.Text = "Вычислить значение по формуле:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 24);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Условие";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 238);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 10;
            label6.Text = "Ввод данных";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(480, 238);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 11;
            label7.Text = "Вывод данных";
            // 
            // button1
            // 
            button1.Location = new Point(676, 364);
            button1.Name = "button1";
            button1.Size = new Size(51, 51);
            button1.TabIndex = 12;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxVarA);
            Controls.Add(label1);
            MinimumSize = new Size(818, 500);
            Name = "Form1";
            Text = "Спринт 6 | Таск 0 | Вариант 21 | Коробейникова Д.Д.";
            Load += buttonDone_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxVarA;
        private Label label2;
        private Label label3;
        private TextBox textBoxResult;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}
