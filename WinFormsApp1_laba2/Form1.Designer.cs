namespace WinFormsApp1_laba2
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
            width = new TextBox();
            height = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // width
            // 
            width.Location = new Point(263, 51);
            width.Name = "width";
            width.Size = new Size(125, 27);
            width.TabIndex = 0;
            width.TextChanged += textBox1_TextChanged;
            width.KeyUp += Ctrl_KeyUp;
            // 
            // height
            // 
            height.Location = new Point(263, 100);
            height.Name = "height";
            height.Size = new Size(125, 27);
            height.TabIndex = 1;
            height.KeyUp += Ctrl_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(245, 20);
            label1.TabIndex = 2;
            label1.Text = "Введите ширину прямоугольника";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 3;
            label2.Text = "Введите высоту прямоугольника";
            // 
            // button1
            // 
            button1.Location = new Point(12, 143);
            button1.Name = "button1";
            button1.Size = new Size(376, 39);
            button1.TabIndex = 2;
            button1.Text = "Посчитать квадраты";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyUp += Ctrl_KeyUp;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(190, 32);
            button2.TabIndex = 4;
            button2.Text = "Задание";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // clear
            // 
            clear.Location = new Point(223, 12);
            clear.Name = "clear";
            clear.Size = new Size(165, 31);
            clear.TabIndex = 5;
            clear.Text = "Очистка";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button3_Click;
            clear.KeyUp += Ctrl_KeyUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 203);
            Controls.Add(clear);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(height);
            Controls.Add(width);
            Name = "Form1";
            Text = "Задание 2 (вар.16)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox width;
        private TextBox height;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button clear;
    }
}
