namespace Tyuiu.KorobeinikovaDD.Sprint6.Task6.V19
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            button1 = new Button();
            openFileDialogTask = new OpenFileDialog();
            groupBoxOutPutData = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            buttonDone = new Button();
            textBoxResult = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            toolTip2 = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            groupBoxOutPutData.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(29, 9);
            button1.Name = "button1";
            button1.Size = new Size(105, 82);
            button1.TabIndex = 0;
            toolTip2.SetToolTip(button1, "Открыть файл.\r\nВыберите нужный файл для обработки.\r\n");
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonOpen_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxLoadFromFile);
            groupBoxOutPutData.Location = new Point(29, 165);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(500, 492);
            groupBoxOutPutData.TabIndex = 1;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод:";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Dock = DockStyle.Top;
            textBoxLoadFromFile.ForeColor = SystemColors.ActiveCaptionText;
            textBoxLoadFromFile.Location = new Point(3, 23);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile.Size = new Size(494, 469);
            textBoxLoadFromFile.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(140, 9);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(104, 82);
            buttonDone.TabIndex = 2;
            toolTip1.SetToolTip(buttonDone, "Выполнить обработку файла");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(0, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(500, 469);
            textBoxResult.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResult);
            groupBox1.Location = new Point(545, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 492);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(946, 9);
            button2.Name = "button2";
            button2.Size = new Size(99, 82);
            button2.TabIndex = 5;
            toolTip3.SetToolTip(button2, "Данные о программе");
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonHelp_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(29, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1016, 69);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(925, 40);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // toolTip2
            // 
            toolTip2.ShowAlways = true;
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Подсказка";
            toolTip2.Popup += toolTip2_Popup;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Выполнить";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = "Справка";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 674);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutPutData);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 19 | Коробейникова Д.Д.";
            Load += FormMain_Load;
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialogTask;
        private GroupBox groupBoxOutPutData;
        private Button buttonDone;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
        private GroupBox groupBox1;
        private Button button2;
        private GroupBox groupBox2;
        private ToolTip toolTip2;
        private ToolTip toolTip1;
        private ToolTip toolTip3;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}
