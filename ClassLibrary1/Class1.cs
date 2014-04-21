using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;

namespace TicTacToe
{
    public enum TicTacToeStatus
    {
        PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins
    }

    public class TicTacToeEngine
    {
        private String plaatje = "";
        private int _beurt = 0;

        public TicTacToeStatus Status { get; set; }
        public List<string> Buttons { get; set; }

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
            plaatje = Status == TicTacToeStatus.PlayerOPlays ? "O" : "X";

        }

        public bool DetermineWinner(string s1, string s2, string s3)
        {
            return s1 == s2 && s1 == s3 && !s1.Equals("");
        }

        public void EmptyButtons()
        {
            
        }
        
    }

}

public class TicTacToeCLI
{
    private TicTacToeEngine TicTacToeGame { set; get; }

    public TicTacToeCLI()
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


    public static void drawBoard()
    {
        
    }

    public static void playerData()
    {
        
    }

}
