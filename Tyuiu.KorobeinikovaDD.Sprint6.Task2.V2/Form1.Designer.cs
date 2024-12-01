namespace Tyuiu.KorobeinikovaDD.Sprint6.Task2.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            f = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textboxST = new TextBox();
            textboxEND = new TextBox();
            button1 = new Button();
            buttonDone = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, f });
            dataGridView1.Location = new Point(673, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(286, 394);
            dataGridView1.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // f
            // 
            f.HeaderText = "f(X)";
            f.MinimumWidth = 6;
            f.Name = "f";
            f.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Условие";
            // 
            // textboxST
            // 
            textboxST.Location = new Point(36, 415);
            textboxST.Multiline = true;
            textboxST.Name = "textboxST";
            textboxST.Size = new Size(135, 46);
            textboxST.TabIndex = 3;
            // 
            // textboxEND
            // 
            textboxEND.Location = new Point(209, 415);
            textboxEND.Multiline = true;
            textboxEND.Name = "textboxEND";
            textboxEND.Size = new Size(135, 46);
            textboxEND.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Location = new Point(385, 386);
            button1.Name = "button1";
            button1.Size = new Size(106, 71);
            button1.TabIndex = 5;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Lime;
            buttonDone.Location = new Point(512, 386);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(135, 71);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Вычислить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 392);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 7;
            label3.Text = "Старт шаг:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 392);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 8;
            label4.Text = "Конец шага:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 357);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 9;
            label5.Text = "Ввод данных:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(673, 9);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 10;
            label6.Text = "Вывод данных:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(673, 44);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 11;
            label7.Text = "Результат";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 54);
            label8.Name = "label8";
            label8.Size = new Size(453, 20);
            label8.TabIndex = 12;
            label8.Text = "Вывести таблицу значений функций на заданном отрезке [-5,5]\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_11_25_02_38_29;
            pictureBox1.Location = new Point(36, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(473, 46);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(987, 67);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(572, 390);
            chart1.TabIndex = 14;
            chart1.Text = "chart1";
            title1.Name = "График функции";
            chart1.Titles.Add(title1);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 493);
            Controls.Add(chart1);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonDone);
            Controls.Add(button1);
            Controls.Add(textboxEND);
            Controls.Add(textboxST);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MinimumSize = new Size(1600, 540);
            Name = "Form1";
            Text = "Спринт 6 | Таск 2 | Вариант 2 | Коробейникова Д.Д.";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textboxST;
        private TextBox textboxEND;
        private Button button1;
        private Button buttonDone;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn f;
        private Label label8;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
