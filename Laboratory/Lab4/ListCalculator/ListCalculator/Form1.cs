using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();

            for(int i = 0; i<10; i++)
            {
                listBox1.Items.Add(rand.Next(1, 101));
            }

            button1.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button3.Enabled = false;
        }

        string[] listArray = new string[10];
        string[] listArrayOfMultiply = new string[10];

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<listBox1.Items.Count;i++)
            {
                listArray[i] = listBox1.Items[i].ToString();
                listBox2.Items.Add(listArray[i]);
            }

            label1.Text = "All Items Copied to List 2";
            button1.Enabled = false;
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] listArrayOfMultiply = new int[10];

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listArrayOfMultiply[i] = Convert.ToInt32(listBox2.Items[i]);
                listArrayOfMultiply[i] = listArrayOfMultiply[i] * 10;

            }
            listBox2.Items.Clear();
            for (int i = 0; i < listArrayOfMultiply.Length; i++)
            {
                listBox2.Items.Add(listArrayOfMultiply[i]);
            }
            label1.Text = "Items Multiplied by 10";
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button3.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i=0;i<listArrayOfMultiply.Length;i++)
            {
                sum += Convert.ToInt32(listBox2.Items[i]);
            }

            label2.Text = sum.ToString();
            label1.Text = "Array Sum Calculated";

            button1.Enabled = false;

            button2.Enabled = false;

            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;

        }

        int[] NewListArray = new int[10];
        private void button4_Click(object sender, EventArgs e)
        {
            
            
            for(int x = 0; x < listArrayOfMultiply.Length; x++)
            {

                NewListArray[x] = Convert.ToInt32(listBox2.Items[x]);
            }


            label3.Text = NewListArray.Min().ToString();
            label1.Text = "Array Min Calculated";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int avg = 0;

            for(int i = 0; i< NewListArray.Length; i++)
            {
                avg += NewListArray[i];

            }
            avg /= NewListArray.Length;

            label4.Text = avg.ToString();

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false; 
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null)
            {
                MessageBox.Show("PLEASE SELECT ITEM");
            }
            else
            {

                label6.Text = "Selected Value is :" + listBox1.SelectedItem.ToString();
                label5.Text = "Selected Index is :" + listBox1.SelectedIndex.ToString();
            }
        }

    }

}
