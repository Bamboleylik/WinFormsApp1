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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBoxSecond = new TextBox();
            textBoxFirst = new TextBox();
            labelResult = new Label();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            buttonClear = new Button();
            buttonCalculate = new Button();
            listBoxHistory = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(99, 233);
            button1.Name = "button1";
            button1.Size = new Size(28, 29);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(221, 233);
            button2.Name = "button2";
            button2.Size = new Size(28, 29);
            button2.TabIndex = 1;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(99, 283);
            button3.Name = "button3";
            button3.Size = new Size(28, 29);
            button3.TabIndex = 2;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(158, 233);
            button4.Name = "button4";
            button4.Size = new Size(28, 29);
            button4.TabIndex = 3;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(158, 335);
            button5.Name = "button5";
            button5.Size = new Size(28, 29);
            button5.TabIndex = 4;
            button5.Text = "8";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(158, 283);
            button6.Name = "button6";
            button6.Size = new Size(28, 29);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(99, 335);
            button7.Name = "button7";
            button7.Size = new Size(28, 29);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(221, 283);
            button8.Name = "button8";
            button8.Size = new Size(28, 29);
            button8.TabIndex = 7;
            button8.Text = "6\\";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(221, 335);
            button9.Name = "button9";
            button9.Size = new Size(28, 29);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(281, 98);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(28, 27);
            textBoxSecond.TabIndex = 9;
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(89, 126);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(169, 27);
            textBoxFirst.TabIndex = 10;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(136, 186);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(50, 20);
            labelResult.TabIndex = 11;
            labelResult.Text = "answe";
            labelResult.Click += label1_Click;
            // 
            // button10
            // 
            button10.Location = new Point(350, 43);
            button10.Name = "button10";
            button10.Size = new Size(28, 29);
            button10.TabIndex = 12;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(412, 43);
            button11.Name = "button11";
            button11.Size = new Size(28, 29);
            button11.TabIndex = 13;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(350, 98);
            button12.Name = "button12";
            button12.Size = new Size(28, 29);
            button12.TabIndex = 14;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(412, 98);
            button13.Name = "button13";
            button13.Size = new Size(28, 29);
            button13.TabIndex = 15;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(158, 391);
            button14.Name = "button14";
            button14.Size = new Size(28, 29);
            button14.TabIndex = 16;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(350, 273);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(84, 29);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "restore";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(350, 168);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(79, 57);
            buttonCalculate.TabIndex = 18;
            buttonCalculate.Text = "=";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += button15_Click;
            // 
            // listBoxHistory
            // 
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.ItemHeight = 20;
            listBoxHistory.Location = new Point(371, 349);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(122, 284);
            listBoxHistory.TabIndex = 19;
         
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 673);
            Controls.Add(listBoxHistory);
            Controls.Add(buttonCalculate);
            Controls.Add(buttonClear);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(labelResult);
            Controls.Add(textBoxFirst);
            Controls.Add(textBoxSecond);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBoxSecond;
        private TextBox textBoxFirst;
        private Label labelResult;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button buttonClear;
        private Button buttonCalculate;
        private ListBox listBoxHistory;
    }
}