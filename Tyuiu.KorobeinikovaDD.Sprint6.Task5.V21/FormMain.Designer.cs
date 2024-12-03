namespace Tyuiu.KorobeinikovaDD.Sprint6.Task5.V21
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
            dataGridViewNums = new DataGridView();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(0, 20);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(264, 472);
            dataGridViewNums.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(724, 23);
            button1.Name = "button1";
            button1.Size = new Size(139, 91);
            button1.TabIndex = 1;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 102);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 23);
            label1.Name = "label1";
            label1.Size = new Size(672, 40);
            label1.TabIndex = 0;
            label1.Text = "Прочитать данные из файла InPutFileTask5V21.txt, вывести в dataGridView все числа, кратные 3. \r\nПостроить диаграмму по этим значениям";
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Location = new Point(869, 23);
            button2.Name = "button2";
            button2.Size = new Size(139, 91);
            button2.TabIndex = 3;
            button2.Text = "Открыть файл";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonOpen_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Location = new Point(1014, 23);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(139, 91);
            button3.TabIndex = 4;
            button3.Text = "Справка";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonHelp_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewNums);
            groupBox2.Location = new Point(12, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 492);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            chart1.Location = new Point(282, 120);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(871, 492);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 633);
            Controls.Add(chart1);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            MinimumSize = new Size(1200, 680);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 21 | Коробейникова Д.Д.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewNums;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
    }
}
