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
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            buttonOpen = new Button();
            buttonInfo = new Button();
            groupBoxIn = new GroupBox();
            chartOut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartOut).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Dock = DockStyle.Fill;
            dataGridViewNums.Location = new Point(3, 23);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(258, 466);
            dataGridViewNums.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(724, 23);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(139, 91);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
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
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(672, 40);
            label1.TabIndex = 0;
            label1.Text = "Прочитать данные из файла InPutFileTask5V21.txt, вывести в dataGridView все числа, кратные 3. \r\nПостроить диаграмму по этим значениям";
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.CornflowerBlue;
            buttonOpen.Location = new Point(869, 23);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(139, 91);
            buttonOpen.TabIndex = 3;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackColor = Color.MediumTurquoise;
            buttonInfo.Location = new Point(1014, 23);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.RightToLeft = RightToLeft.Yes;
            buttonInfo.Size = new Size(139, 91);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonHelp_Click;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxIn.Controls.Add(dataGridViewNums);
            groupBoxIn.Location = new Point(12, 120);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(264, 492);
            groupBoxIn.TabIndex = 5;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Вывод данных:";
            // 
            // chartOut
            // 
            chartOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartOut.BackColor = SystemColors.ControlLightLight;
            chartArea2.Name = "ChartArea1";
            chartOut.ChartAreas.Add(chartArea2);
            chartOut.Location = new Point(282, 120);
            chartOut.Name = "chartOut";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chartOut.Series.Add(series2);
            chartOut.Size = new Size(871, 492);
            chartOut.TabIndex = 6;
            chartOut.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 633);
            Controls.Add(chartOut);
            Controls.Add(groupBoxIn);
            Controls.Add(buttonInfo);
            Controls.Add(buttonOpen);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone);
            MinimumSize = new Size(1200, 680);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 21 | Коробейникова Д.Д.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewNums;
        private Button buttonDone;
        private GroupBox groupBox1;
        private Button buttonOpen;
        private Button buttonInfo;
        private GroupBox groupBoxIn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOut;
        private Label label1;
    }
}
