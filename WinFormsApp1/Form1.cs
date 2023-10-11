using InterestCalculatorLibrary;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(principalTextBox.Text);
            double rate = Convert.ToDouble(rateTextBox.Text);
            int periods = Convert.ToInt32(periodsTextBox.Text);
            double result = 0.0;

            if (simpleInterestRadioButton.Checked)
            {
                result = Convert.ToDouble(InterestCalculator.CalculateSimpleInterest(principal, rate, periods));
            }
            else if (compoundInterestRadioButton.Checked)
            {
                result = Convert.ToDouble(InterestCalculator.CalculateCompoundInterest(principal, rate, periods));
            }
            else if (continuousInterestRadioButton.Checked)
            {
                result = Convert.ToDouble(InterestCalculator.CalculateContinuousInterest(principal, rate, periods));
            }

            result = Math.Round(result, 3);
            reslTextBox.Text = "" + result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}