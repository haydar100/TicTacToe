using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int _turn = 0;
        private string image = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visual Studio sucks !");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            if (_turn%2 == 1)
                image = "X";
            else
                image = "O";
            if (b.Text.Equals(""))
                b.Text = image;
            _turn++;

            if (!(checkForWinner(button1, button2, button3) ||
            checkForWinner(button4, button5, button6) ||
            checkForWinner(button7, button8, button9) ||
            checkForWinner(button1, button5, button9) ||
            checkForWinner(button3, button5, button7) ||
            checkForWinner(button1, button4, button7) ||
            checkForWinner(button2, button5, button8) ||
            checkForWinner(button3, button6, button9)) && _turn == 9)
            {
                System.Windows.Forms.MessageBox.Show("Draw!.",
                    "there is no winner!");
                removeText();
            }

        }


        private void removeText()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }




        private bool checkForWinner(Button b1, Button b2, Button b3) 
        {
           if (b1.Text.Equals(b2.Text) &&  b1.Text.Equals(b3.Text) && !b1.Text.Equals(""))
            {
                MessageBox.Show("Congratulations player " + image + " won", "there is a winner!"); removeText();
                return true;
            }
            return false;
        }


        
    }
}

