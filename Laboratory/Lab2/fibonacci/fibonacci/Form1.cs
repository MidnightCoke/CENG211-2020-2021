using System;

using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            int user_number = Convert.ToInt32(textBox1.Text);

            Fibonacci(user_number);

        }

        private void Fibonacci(int n)
        {

            int a = 0, b = 1, i, c, j;
            if (label1.Text == "") { 
            for(i=1;i<=n;i++)
            {
                a = 0;
                b = 1;
                label1.Text += b + " ";
                for(j=1;j<i;j++)
                {
                    c = a + b;
                    label1.Text += c + " ";
                    a = b;
                    b = c;

                }
                label1.Text += "\n";
            }
            }
            else
            {
                label1.Text = "";
                for (i = 1; i <= n; i++)
                {
                    a = 0;
                    b = 1;
                    label1.Text += b + " ";
                    for (j = 1; j < i; j++)
                    {
                        c = a + b;
                        label1.Text += c + " ";
                        a = b;
                        b = c;

                    }
                    label1.Text += "\n";
                }
            }

        }
    }
}
