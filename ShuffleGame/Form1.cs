using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShuffleGame
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        public void CheckButton(Button bttn1, Button bttn2)
        {
            if (bttn2.Text == "")
            {
                bttn2.Text = bttn1.Text;
                bttn1.Text = "";
            }
        }

        public void CheckSolve()
        {
            num = num + 1;
            label1.Text = num + " ";
            if (button1.Text=="1"&& button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "")
            {
                MessageBox.Show("You did it in" + num + " click");
            }
        }   

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckButton(button1, button2);
            CheckButton(button1, button5);
            CheckSolve();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckButton(button2, button1);
            CheckButton(button2, button3);
            CheckButton(button2, button6);
            CheckSolve();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CheckButton(button3, button2);
            CheckButton(button3, button4);
            CheckButton(button3, button7);
            CheckSolve();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CheckButton(button4, button3);
            CheckButton(button4, button8);
            CheckSolve();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            CheckButton(button5, button1);
            CheckButton(button5, button6);
            CheckButton(button5, button9);
            CheckSolve();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            CheckButton(button6, button5);
            CheckButton(button6, button2);
            CheckButton(button6, button7);
            CheckButton(button6, button10);
            CheckSolve();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            CheckButton(button7, button6);
            CheckButton(button7, button3);
            CheckButton(button7, button8);
            CheckButton(button7, button11);
            CheckSolve();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            CheckButton(button8, button7);
            CheckButton(button8, button4);
            CheckButton(button8, button12);
            CheckSolve();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            CheckButton(button9, button5);
            CheckButton(button9, button10);
            CheckButton(button9, button13);
            CheckSolve();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            CheckButton(button10, button9);
            CheckButton(button10, button6);
            CheckButton(button10, button11);
            CheckButton(button10, button14);
            CheckSolve();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            CheckButton(button11, button10);
            CheckButton(button11, button7);
            CheckButton(button11, button12);
            CheckButton(button11, button15);
            CheckSolve();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            CheckButton(button12, button8);
            CheckButton(button12, button11);
            CheckButton(button12, button16);
            CheckSolve();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            CheckButton(button13, button9);
            CheckButton(button13, button14);
            CheckSolve();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            CheckButton(button14, button13);
            CheckButton(button14, button10);
            CheckButton(button14, button15);
            CheckSolve();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            CheckButton(button15, button14);
            CheckButton(button15, button11);
            CheckButton(button15, button16);
            CheckSolve();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            CheckButton(button16, button12);
            CheckButton(button16, button15);
            CheckSolve();
        }

        public void Shuffle()
        {
            int i, j, Rn;
            int[] a = new int[16];
            Boolean Flags = false;
            i = 1;
            do
            {
                Random rnd = new Random();
                Rn = Convert.ToInt32(rnd.Next(0, 15) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (a[j] == Rn)
                    {
                        Flags = true;
                        break;   
                    }
                }
                if (Flags == true)
                {
                    Flags = false;
                }
                else
                {
                    a[i] = Rn;
                    i = i + 1;

                }
            }
            while (i <= 15);
            button1.Text = Convert.ToString(a[1]);
            button2.Text = Convert.ToString(a[2]);
            button3.Text = Convert.ToString(a[3]);
            button4.Text = Convert.ToString(a[4]);
            button5.Text = Convert.ToString(a[5]);
            button6.Text = Convert.ToString(a[6]);
            button7.Text = Convert.ToString(a[7]);
            button8.Text = Convert.ToString(a[8]);
            button9.Text = Convert.ToString(a[9]);
            button10.Text = Convert.ToString(a[10]);
            button11.Text = Convert.ToString(a[11]);
            button12.Text = Convert.ToString(a[12]);
            button13.Text = Convert.ToString(a[13]);
            button14.Text = Convert.ToString(a[14]);
            button15.Text = Convert.ToString(a[15]);
            button16.Text = "";
            num = 0;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
