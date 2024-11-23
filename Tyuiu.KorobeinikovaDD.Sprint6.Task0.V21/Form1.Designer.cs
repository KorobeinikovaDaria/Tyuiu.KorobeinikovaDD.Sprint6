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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            textBoxVarA.Location = new Point(34, 207);
            textBoxVarA.Multiline = true;
            textBoxVarA.Name = "textBoxVarA";
            textBoxVarA.Size = new Size(167, 51);
            textBoxVarA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 171);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите значение х:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 171);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(239, 207);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(172, 51);
            textBoxResult.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(491, 94);
            button2.Name = "button2";
            button2.Size = new Size(212, 117);
            button2.TabIndex = 6;
            button2.Text = "Вычислить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonDone_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_11_24_03_33_11;
            pictureBox1.Location = new Point(34, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 62);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 34);
            label4.Name = "label4";
            label4.Size = new Size(245, 20);
            label4.TabIndex = 8;
            label4.Text = "Вычислить значение по формуле:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxVarA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += buttonDone_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label4;
    }
}
