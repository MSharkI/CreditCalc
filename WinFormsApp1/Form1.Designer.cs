namespace WinFormsApp1
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
            principalTextBox = new TextBox();
            rateTextBox = new TextBox();
            periodsTextBox = new TextBox();
            button1 = new Button();
            simpleInterestRadioButton = new RadioButton();
            compoundInterestRadioButton = new RadioButton();
            continuousInterestRadioButton = new RadioButton();
            reslTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // principalTextBox
            // 
            principalTextBox.Location = new Point(133, 6);
            principalTextBox.Name = "principalTextBox";
            principalTextBox.Size = new Size(100, 23);
            principalTextBox.TabIndex = 0;
            principalTextBox.TextChanged += textBox1_TextChanged;
            // 
            // rateTextBox
            // 
            rateTextBox.Location = new Point(133, 41);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(100, 23);
            rateTextBox.TabIndex = 1;
            // 
            // periodsTextBox
            // 
            periodsTextBox.Location = new Point(133, 74);
            periodsTextBox.Name = "periodsTextBox";
            periodsTextBox.Size = new Size(100, 23);
            periodsTextBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(261, 133);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 3;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // simpleInterestRadioButton
            // 
            simpleInterestRadioButton.AutoSize = true;
            simpleInterestRadioButton.Location = new Point(250, 12);
            simpleInterestRadioButton.Name = "simpleInterestRadioButton";
            simpleInterestRadioButton.Size = new Size(132, 19);
            simpleInterestRadioButton.TabIndex = 5;
            simpleInterestRadioButton.TabStop = true;
            simpleInterestRadioButton.Text = "Простые проценты";
            simpleInterestRadioButton.UseVisualStyleBackColor = true;
            // 
            // compoundInterestRadioButton
            // 
            compoundInterestRadioButton.AutoSize = true;
            compoundInterestRadioButton.Location = new Point(250, 37);
            compoundInterestRadioButton.Name = "compoundInterestRadioButton";
            compoundInterestRadioButton.Size = new Size(136, 19);
            compoundInterestRadioButton.TabIndex = 6;
            compoundInterestRadioButton.TabStop = true;
            compoundInterestRadioButton.Text = "Сложные проценты";
            compoundInterestRadioButton.UseVisualStyleBackColor = true;
            // 
            // continuousInterestRadioButton
            // 
            continuousInterestRadioButton.AutoSize = true;
            continuousInterestRadioButton.Location = new Point(250, 62);
            continuousInterestRadioButton.Name = "continuousInterestRadioButton";
            continuousInterestRadioButton.Size = new Size(162, 19);
            continuousInterestRadioButton.TabIndex = 7;
            continuousInterestRadioButton.TabStop = true;
            continuousInterestRadioButton.Text = "Непрерывные проценты";
            continuousInterestRadioButton.UseVisualStyleBackColor = true;
            // 
            // reslTextBox
            // 
            reslTextBox.Location = new Point(81, 146);
            reslTextBox.Name = "reslTextBox";
            reslTextBox.Size = new Size(152, 23);
            reslTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 9;
            label1.Text = "Результат:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 10;
            label2.Text = "Исходная сумма:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 11;
            label3.Text = "Число периодов:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 44);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 12;
            label4.Text = "Процентная ставка:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 192);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reslTextBox);
            Controls.Add(continuousInterestRadioButton);
            Controls.Add(compoundInterestRadioButton);
            Controls.Add(simpleInterestRadioButton);
            Controls.Add(button1);
            Controls.Add(periodsTextBox);
            Controls.Add(rateTextBox);
            Controls.Add(principalTextBox);
            Name = "Form1";
            Text = "Подсчет процентов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox principalTextBox;
        private TextBox rateTextBox;
        private TextBox periodsTextBox;
        private Button button1;
        private RadioButton simpleInterestRadioButton;
        private RadioButton compoundInterestRadioButton;
        private RadioButton continuousInterestRadioButton;
        private TextBox reslTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}