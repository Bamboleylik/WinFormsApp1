using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox? activeTextBox = null;

        public Form1()
        {
            InitializeComponent();
            SetupButtons();
        }

        private void SetupButtons()
        {
            foreach (var btn in new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button14 })
            {
                btn.Click += NumberButton_Click;
            }

            foreach (var btn in new Button[] { button10, button11, button12, button13 })
            {
                btn.Click += OperationButton_Click;
            }

            buttonClear.Click += buttonClear_Click;
            buttonCalculate.Click += buttonCalculate_Click;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            textBoxFirst.ReadOnly = true;
            textBoxSecond.ReadOnly = true;

            textBoxFirst.Enter += (s, e) => activeTextBox = textBoxFirst;
            textBoxSecond.Enter += (s, e) => activeTextBox = textBoxSecond;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null && sender is Button btn)
            {
                activeTextBox.Text += btn.Text;
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null && sender is Button btn)
            {
                activeTextBox.Text += btn.Text;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

     
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirst.Text = "";
            textBoxSecond.Text = "";
            labelResult.Text = "Результат:";
           
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBoxFirst.Text;
                var result = new System.Data.DataTable().Compute(expression, null);
                labelResult.Text = "Результат: " + result.ToString();

               
                listBoxHistory.Items.Insert(0, expression + " = " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка в виразі: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
