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
            button1 = new Button();
            openFileDialogTask = new OpenFileDialog();
            groupBoxOutPutData = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            buttonDone = new Button();
            textBoxResult = new TextBox();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(29, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 59);
            button1.TabIndex = 0;
            button1.Text = "button1";
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
            groupBoxOutPutData.Location = new Point(29, 101);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(250, 292);
            groupBoxOutPutData.TabIndex = 1;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "groupBox1";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(0, 26);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.Size = new Size(244, 266);
            textBoxLoadFromFile.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(129, 25);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(94, 59);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "button2";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(341, 127);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(244, 266);
            textBoxResult.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(button1);
            Name = "FormMain";
            Text = "Form1";
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialogTask;
        private GroupBox groupBoxOutPutData;
        private Button buttonDone;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
    }
}
