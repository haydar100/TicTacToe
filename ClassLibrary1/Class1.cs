using System;
using System.Collections.Generic;
using System.Resources;
using TicTacToe;

namespace TicTacToe
{
    public enum TicTacToeStatus
    {
        PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins
    }

    public class TicTacToeEngine
    {
        private String _image = "";
        private int _beurt = 0;

        public TicTacToeStatus Status { get; set; }
        public List<string> Buttons { get; set; }

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public TicTacToeEngine()
        {
            Buttons = new List<string>(); 
            for (int i = 0; i < 9; i++)
            {
                Buttons.Add("");
            }
        }


        public bool ChooseCell(int button)
        {
            Image = Status == TicTacToeStatus.PlayerOPlays ? "O" : "X";
            // determine if the button has no text 
            if (Buttons[button] == "")
            {
                Buttons[button] = _image;
                Status = (Status == TicTacToeStatus.PlayerOPlays
                    ? TicTacToeStatus.PlayerXPlays
                    : TicTacToeStatus.PlayerOPlays);
                _beurt++; // +1 each time on the counter
            }
            else {return false;}
            // determine winner but how ? maybe a boolean to return the winner and if the _beurt is on 9 just return a draw status ?


            return true; // placeholder until method is done

        }

        public bool DetermineWinner(string s1, string s2, string s3)
        {
            return s1 == s2 && s1 == s3 && !s1.Equals(""); // on the GUI i had buttons as parameters, switched them to string
        }

        public void EmptyButtons()
        {
            for (int i = 0; i < Buttons.Count; i++) // count the buttons, setText empty string.
            {
                Buttons[i] = "";
            }
            _beurt = 0; // also reset the counter 
        }
        
    }

}


// need to code something that will start the game as the console version or as the GUI version

public class TicTacToeCli
{
    private TicTacToeEngine TicTacToeGame { set; get; }

    public TicTacToeCli()
    {
        TicTacToeGame = new TicTacToeEngine();
    }

    static void Start()
    {
        Console.Title = ("TicTacToe Console version ");
        Console.WriteLine("TicTacToe started...");
        Console.WriteLine("This is the Console version of the game !");
        Console.ReadLine();
        Console.Clear();

    }


    public static void DrawBoard()
    {
        
    }

    public static void PlayerData()
    {
        
    }

}
