namespace Tyuiu.KorobeinikovaDD.Sprint6.Task3.V26
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
            dataGridRes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dataGridMatrix = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridRes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMatrix).BeginInit();
            SuspendLayout();
            // 
            // dataGridRes
            // 
            dataGridRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRes.Location = new Point(576, 62);
            dataGridRes.Name = "dataGridRes";
            dataGridRes.RowHeadersWidth = 51;
            dataGridRes.Size = new Size(263, 297);
            dataGridRes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(576, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Вывод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(576, 39);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Результат";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 30);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Условие";
            // 
            // button1
            // 
            button1.Location = new Point(576, 365);
            button1.Name = "button1";
            button1.Size = new Size(54, 40);
            button1.TabIndex = 4;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonHelp_Click;
            // 
            // button2
            // 
            button2.Location = new Point(700, 365);
            button2.Name = "button2";
            button2.Size = new Size(139, 40);
            button2.TabIndex = 5;
            button2.Text = "Выполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonDone_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 201);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(26, 85);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 62);
            label5.Name = "label5";
            label5.Size = new Size(213, 20);
            label5.TabIndex = 9;
            label5.Text = "Дан массив 5 на 5 элементов";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 88);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 10;
            label6.Text = "16  19  17   2   8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 118);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 11;
            label7.Text = "-17   8 -17  -8   1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 148);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 12;
            label8.Text = "-7  17  -2   1  -3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 181);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 13;
            label9.Text = "-12   0 -17  15   6";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 210);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 14;
            label10.Text = "17  -6 -17  18 -19";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 241);
            label11.Name = "label11";
            label11.Size = new Size(204, 20);
            label11.TabIndex = 15;
            label11.Text = "Заменить четные значения ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 261);
            label12.Name = "label12";
            label12.Size = new Size(158, 20);
            label12.TabIndex = 16;
            label12.Text = "в третьей строке на 0";
            // 
            // dataGridMatrix
            // 
            dataGridMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMatrix.Location = new Point(270, 62);
            dataGridMatrix.Name = "dataGridMatrix";
            dataGridMatrix.RowHeadersWidth = 51;
            dataGridMatrix.Size = new Size(263, 297);
            dataGridMatrix.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 450);
            Controls.Add(dataGridMatrix);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridRes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridRes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridRes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dataGridMatrix;
    }
}
