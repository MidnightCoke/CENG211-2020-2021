using System;
using System.Drawing;
using System.Windows.Forms;

namespace RollDice
{
    public partial class Form1 : Form
    {
        public Image[] diceImages
        {
            get;
            private set;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diceImages = new Image[7];
            diceImages[0] = Properties.Resources._1;

            diceImages[1] = Properties.Resources._2;

            diceImages[2] = Properties.Resources._3;

            diceImages[3] = Properties.Resources._4;

            diceImages[4] = Properties.Resources._5;

            diceImages[5] = Properties.Resources._6;
            var rand = new Random();
            int diceOneNumber,
            diceTwoNumber,
            diceThreeNumber,
            diceFourNumber;

            roll_Dice();

            void roll_Dice()
            {
                diceOneNumber = rand.Next(1, 7);
                label1.Image = diceImages[diceOneNumber - 1];
                diceTwoNumber = rand.Next(1, 7);
                label2.Image = diceImages[diceTwoNumber - 1];
                diceThreeNumber = rand.Next(1, 7);
                label3.Image = diceImages[diceThreeNumber - 1];
                diceFourNumber = rand.Next(1, 7);
                label4.Image = diceImages[diceFourNumber - 1];

            }
        }

    }
}