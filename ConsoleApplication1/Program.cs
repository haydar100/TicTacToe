using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    class Program
    {
        static int[] _playField = new int[9];
        static void Main(string[] args)
        {
            Start();
      
        }

       static void Start()
       {
           Console.Title = ("TicTacToe Console version ");
           Console.WriteLine("TicTacToe started...");
           Console.WriteLine("This is the Console version of the game !");
           Console.ReadLine();
           Console.Clear();

        }

        static void playerData(String player)
        {
            Console.WriteLine("Player : " + player);
        }
    }
}
