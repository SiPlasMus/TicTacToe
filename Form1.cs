using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Boolean order = true;
        System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[10];

        public Form1()
        {
            InitializeComponent();
            buttons[1] = button1; buttons[2] = button2; buttons[3] = button3; buttons[4] = button4; buttons[5] = button5; buttons[6] = button6; buttons[7] = button7; buttons[8] = button8; buttons[9] = button9;
            for (int i = 1; i < buttons.Length; i++)
            {
                buttons[i].Text = "";
            }
        }
        public string isThree ()
        {
            for (int i = 1;i < 4; i++)
                if ((buttons[i].Text == buttons[i+3].Text) && (buttons[i+3].Text == buttons[i + 6].Text))
                    return buttons[i].Text;
            for (int i = 1; i < buttons.Length; i+=3)
                if (buttons[i].Text == buttons[i + 1].Text && buttons[i + 1].Text == buttons[i + 2].Text)
                    return buttons[i].Text;
            if (buttons[1].Text == buttons[5].Text && buttons[5].Text == buttons[9].Text)
                return buttons[1].Text;
            if (buttons[3].Text == buttons[5].Text && buttons[5].Text == buttons[7].Text)
                return buttons[3].Text;
            for (int i = 1; i < buttons.Length; i++)
            {
                if (buttons[i].Text == "")
                    return "";
            }

            return "=";
        }

        public void isGameOver ()
        {
            if (isThree() != "")
            {
                if (isThree() == "X")
                    MessageBox.Show("X won!");
                    //result.Text = "X Won";
                else if (isThree() == "O")
                    MessageBox.Show("O won!");
                else if (isThree() == "=")
                    MessageBox.Show("No one won");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "") return;
            if (order)
            {
                button1.Text = "X";
                order = false;
                isGameOver();
            }
            else
            { 
                button1.Text = "O";
                button1.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "") return;
            if (order)
            {
                button2.Text = "X";
                order = false;
                isGameOver();
            }
            else
            {
                button2.Text = "O";
                button2.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "") return;
            if (order)
            {
                button3.Text = "X";
                order = false;
                isGameOver();
            }
            else
            {
                button3.Text = "O";
                button3.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "") return;
            if (order)
            {
                button4.Text = "X";
                order = false;
                isGameOver();
            }
            else
            {
                button4.Text = "O";
                button4.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "") return;
            if (order)
            {
                button5.Text = "X";
                order = false;
                isGameOver();
            }
            else
            {
                button5.Text = "O";
                button5.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "") return;
            if (order)
            {
                button6.Text = "X";
                order = false;
                isGameOver();
            }
            else
            {
                button6.Text = "O";
                button6.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "") return;
            if (order)
            {
                button7.Text = "X";
                order = false;
                isGameOver();
            }
            else
            {
                button7.Text = "O";
                button7.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "") return;
            if (order)
            {
                button8.Text = "X";
                order = false;
                isGameOver();
            }
            else
            {
                button8.Text = "O";
                button8.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "") return;
            if (order)
            {
                button9.Text = "X";
                order = false;
                isGameOver();
            }
            else
            {
                button9.Text = "O";
                button9.ForeColor = Color.White;
                order = true;
                isGameOver();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //static void RestartApp(int pid, string applicationName)
        //{
        //    // Wait for the process to terminate
        //    Process process = null;
        //    try
        //    {
        //        process = Process.GetProcessById(pid);
        //        process.WaitForExit(1000);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        // ArgumentException to indicate that the 
        //        // process doesn't exist?   LAME!!
        //    }
        //    Process.Start(applicationName, "");
        //}

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < buttons.Length; i++)
            {
                buttons[i].Text = "";
                order = true;
                buttons[i].ForeColor = Color.DarkViolet;
            }
        }

        
        Point lastPoint;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
