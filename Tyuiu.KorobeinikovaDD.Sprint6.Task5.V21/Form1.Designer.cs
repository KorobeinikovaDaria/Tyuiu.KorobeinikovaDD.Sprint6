﻿namespace Tyuiu.KorobeinikovaDD.Sprint6.Task5.V21
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
            dataGridViewNums = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(12, 31);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(300, 284);
            dataGridViewNums.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(331, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 64);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewNums);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewNums;
        private Button button1;
    }
}
