namespace Tyuiu.KorobeinikovaDD.Sprint6.Task4.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Tablica = new TextBox();
            textboxST = new TextBox();
            textboxEND = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            chart1.Location = new Point(430, 119);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(867, 506);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // Tablica
            // 
            Tablica.Dock = DockStyle.Top;
            Tablica.Location = new Point(3, 23);
            Tablica.Multiline = true;
            Tablica.Name = "Tablica";
            Tablica.ScrollBars = ScrollBars.Vertical;
            Tablica.Size = new Size(390, 480);
            Tablica.TabIndex = 1;
            Tablica.TextChanged += Tablica_TextChanged;
            // 
            // textboxST
            // 
            textboxST.Location = new Point(6, 56);
            textboxST.Name = "textboxST";
            textboxST.Size = new Size(174, 27);
            textboxST.TabIndex = 2;
            // 
            // textboxEND
            // 
            textboxEND.Location = new Point(186, 56);
            textboxEND.Name = "textboxEND";
            textboxEND.Size = new Size(164, 27);
            textboxEND.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(969, 36);
            button1.Name = "button1";
            button1.Size = new Size(112, 65);
            button1.TabIndex = 4;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonDone_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(1080, 36);
            button2.Name = "button2";
            button2.Size = new Size(107, 65);
            button2.TabIndex = 5;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(28, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 95);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(526, 60);
            label3.TabIndex = 0;
            label3.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить файл\r\nOutPutFileTask4V16.txt по нажатию кнопки.\r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textboxST);
            groupBox2.Controls.Add(textboxEND);
            groupBox2.Location = new Point(578, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 95);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 33);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец шага";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 4;
            label1.Text = "Старт шага:";
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.Location = new Point(1187, 36);
            button3.Name = "button3";
            button3.Size = new Size(110, 65);
            button3.TabIndex = 8;
            button3.Text = "Справка";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonHelp_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Tablica);
            groupBox3.Location = new Point(28, 119);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(396, 504);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 650);
            Controls.Add(groupBox3);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chart1);
            MaximumSize = new Size(1400, 700);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 16 | Коробейникова Д.Д.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox Tablica;
        private TextBox textboxST;
        private TextBox textboxEND;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
