using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfterLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Enabled = false;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            button9.BackColor = Color.Green;
        }

        /* Button State */

        public Boolean state_switch = false;
        
        /* UPPERCASE BUTTON */
        private void button2_Click(object sender, EventArgs e)
        {
            if (state_switch)
                MessageBox.Show("Transform String to Uppercase");
            else
            {
                string textBoxTextVar;
                textBoxTextVar = textBox1.Text;
                textBox2.Text = textBoxTextVar.ToUpper();
            }

        }
        /* CLEAR TEXT BUTTON */
        private void button1_Click(object sender, EventArgs e)
        {
            void clearTextBox()
            {
                if (textBox1.Text != "")
                    textBox1.Text = "";
                if (textBox2.Text != "")
                    textBox2.Text = "";
                return;
            }
            if (state_switch)
                 MessageBox.Show("Clears the TextBoxes");
            else
            {
                clearTextBox();
            }
            
        }

        /* LOWERCASE BUTTON */
        private void button7_Click(object sender, EventArgs e)
        {
            if (state_switch)
                MessageBox.Show("Transform String to Lowercase");
            else
            {
                string textBoxTextVar;
                textBoxTextVar = textBox1.Text;
                textBox2.Text = textBoxTextVar.ToLower();
            }
        }
        /* TRIM BUTTON */
        private void button3_Click(object sender, EventArgs e)
        {
            if (state_switch)
                MessageBox.Show("Removes the Whatspaces from String");
            else
            {
                string textBoxTextVar;
                textBoxTextVar = textBox1.Text;
                textBox2.Text = textBoxTextVar.Trim();
            }
        }

        /* HELP BUTTON */
        private void button9_Click(object sender, EventArgs e)
        {
            void ChangeHelpButton()
            {
            if(state_switch)
            {
                button9.Text = "Disable Help";
                button9.BackColor = Color.Red;
                state_switch = false;

            }
            else             {
                button9.Text = "Click For Tips";
                button9.BackColor = Color.Blue;
                state_switch = true;
            }
            }

            ChangeHelpButton();
        }
        /* INDEXOF BUTTON*/
        private void button8_Click(object sender, EventArgs e)
        {
            if (state_switch)
                MessageBox.Show("Checks The email correction");
            else
            {
                string email = textBox1.Text;
                int indexPos = email.IndexOf("@");
                if (indexPos == -1)
                {
                    MessageBox.Show("Invalid entry");
                }
                else
                {
                    MessageBox.Show("This is string contains @ at position: " + indexPos);
                }
            }
            
        }
        /* CONTAINS BUTTON */
        private void button4_Click(object sender, EventArgs e)
        {
            if (state_switch)
                MessageBox.Show("Search for a spesific item");
            else
            {
                string contains = textBox1.Text;
                string searchfor = "Programmer";
                if (contains.Contains(searchfor))
                {
                    MessageBox.Show("It contain the string: " + searchfor);
                }
                else
                {
                    MessageBox.Show("It does not contain the string: " + searchfor);
                }

            }
            
        }
    }
}
