using System;
using System.Windows.Forms;

namespace Factorial_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CalculateFactorial(int num)
        {
            int answer = 1;
            for(int x = 1; x<=num; x++)
            {
                answer *= x;
            }

            return answer;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int fact, answer;
            fact = Convert.ToInt32(textBox1.Text);
            if(fact == 0)
            {
                fact = 1;
            }
            string output = "";
            for(int i = 1; i<=fact;i++)
            {
                answer = CalculateFactorial(i);
                output += answer +  "\n";
            }

            MessageBox.Show(output);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fact;
            fact = Convert.ToInt32(textBox1.Text);
            label2.Text = CalculateFactorial(fact).ToString();

        }
    }
}
