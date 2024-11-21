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
            textBoxVarA.Location = new Point(37, 50);
            textBoxVarA.Name = "textBoxVarA";
            textBoxVarA.Size = new Size(149, 27);
            textBoxVarA.TabIndex = 1;
            textBoxVarA.TextChanged += buttonDone_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 22);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите значение х:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 102);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(37, 136);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(149, 27);
            textBoxResult.TabIndex = 4;
            textBoxResult.TextChanged += buttonHelp_Click;
            // 
            // button2
            // 
            button2.Location = new Point(37, 194);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxVarA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += buttonDone_Click;
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
    }
}
