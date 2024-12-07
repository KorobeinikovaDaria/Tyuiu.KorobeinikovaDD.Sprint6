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
            buttonOpen = new Button();
            openFileDialogTask = new OpenFileDialog();
            groupBoxOutPutData = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            buttonDone = new Button();
            textBoxResult = new TextBox();
            groupBoxResult = new GroupBox();
            buttonInfo = new Button();
            groupBoxTask = new GroupBox();
            Important = new Label();
            toolTipOpen = new ToolTip(components);
            toolTipDone = new ToolTip(components);
            toolTipInfo = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            groupBoxOutPutData.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBoxTask.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(29, 9);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(105, 82);
            buttonOpen.TabIndex = 0;
            toolTipOpen.SetToolTip(buttonOpen, "Открыть файл.\r\nВыберите нужный файл для обработки.\r\n");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutPutData.Controls.Add(textBoxLoadFromFile);
            groupBoxOutPutData.Location = new Point(29, 165);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(507, 496);
            groupBoxOutPutData.TabIndex = 1;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод:";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Dock = DockStyle.Fill;
            textBoxLoadFromFile.ForeColor = SystemColors.ActiveCaptionText;
            textBoxLoadFromFile.Location = new Point(3, 23);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile.Size = new Size(501, 470);
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
            toolTipDone.SetToolTip(buttonDone, "Выполнить обработку файла");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(501, 470);
            textBoxResult.TabIndex = 3;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(545, 165);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(507, 496);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод:";
            groupBoxResult.Enter += groupBox1_Enter;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(953, 9);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(99, 82);
            buttonInfo.TabIndex = 5;
            toolTipInfo.SetToolTip(buttonInfo, "Данные о программе");
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonHelp_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask.Controls.Add(Important);
            groupBoxTask.Location = new Point(29, 90);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1023, 69);
            groupBoxTask.TabIndex = 6;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // Important
            // 
            Important.Dock = DockStyle.Fill;
            Important.Location = new Point(3, 23);
            Important.Name = "Important";
            Important.Size = new Size(1017, 43);
            Important.TabIndex = 0;
            Important.Text = resources.GetString("Important.Text");
            Important.Click += label1_Click;
            // 
            // toolTipOpen
            // 
            toolTipOpen.ShowAlways = true;
            toolTipOpen.ToolTipIcon = ToolTipIcon.Info;
            toolTipOpen.ToolTipTitle = "Подсказка";
            toolTipOpen.Popup += toolTip2_Popup;
            // 
            // toolTipDone
            // 
            toolTipDone.ToolTipIcon = ToolTipIcon.Info;
            toolTipDone.ToolTipTitle = "Выполнить";
            toolTipDone.Popup += toolTip1_Popup;
            // 
            // toolTipInfo
            // 
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo.ToolTipTitle = "Справка";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 678);
            Controls.Add(buttonOpen);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonInfo);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutPutData);
            MinimumSize = new Size(1100, 725);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 19 | Коробейникова Д.Д.";
            Load += FormMain_Load;
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen;
        private OpenFileDialog openFileDialogTask;
        private GroupBox groupBoxOutPutData;
        private Button buttonDone;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
        private GroupBox groupBoxResult;
        private Button buttonInfo;
        private GroupBox groupBoxTask;
        private ToolTip toolTipOpen;
        private ToolTip toolTipDone;
        private ToolTip toolTipInfo;
        private Label Important;
        private OpenFileDialog openFileDialog1;
    }
}
