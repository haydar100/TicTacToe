using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int _turn;
        private string _image = "";
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
            var b = (Button) sender;
            _image = _turn%2 == 1 ? "X" : "O";
            if (b.Text.Equals(""))
                b.Text = _image;
            _turn++;

            if (CheckForWinner(button1, button2, button3) ||
                CheckForWinner(button4, button5, button6) ||
                CheckForWinner(button7, button8, button9) ||
                CheckForWinner(button1, button5, button9) ||
                CheckForWinner(button3, button5, button7) ||
                CheckForWinner(button1, button4, button7) ||
                CheckForWinner(button2, button5, button8) ||
                CheckForWinner(button3, button6, button9) || _turn != 9) return;
            MessageBox.Show("Draw!.",
                "there is no winner!");
            RemoveText();
        }


        private void RemoveText()
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




        private bool CheckForWinner(Button b1, Button b2, Button b3) 
        {
           if (b1.Text.Equals(b2.Text) &&  b1.Text.Equals(b3.Text) && !b1.Text.Equals(""))
            {
                MessageBox.Show("Congratulations player " + _image + " won", "there is a winner!"); RemoveText();
                return true;
            }
            return false;
        }


        
    }
}

