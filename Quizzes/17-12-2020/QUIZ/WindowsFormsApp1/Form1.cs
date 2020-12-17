using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            MessageBox.Show(p1.Greet());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.SetAge(21);
            MessageBox.Show(s1.Greet());
            label1.Text = s1.ShowAge();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher t1 = new Teacher();
            t1.SetAge(30);

            MessageBox.Show(t1.Greet());
            label2.Text = t1.Explain();
        }
    }
}
