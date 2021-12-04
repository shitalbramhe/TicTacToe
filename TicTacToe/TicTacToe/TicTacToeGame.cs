using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public void Creatboard()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
        public void Gameinput()
        {
            Console.WriteLine("Enter Your Input to Play ");
            char playerinput = Convert.ToChar(Console.ReadLine());
            char input = char.ToUpper(playerinput);
            if (input == 'X')
            {
                char compinput = 'O';
                Console.WriteLine("Player input" + input);
                Console.WriteLine("Computer input" + compinput);
            }
            if (input == 'O')
            {
                char compinput = 'X';
                Console.WriteLine("Player input" + input);
                Console.WriteLine("Computer input" + compinput);
            }
        }
        public void Showboard()
        {
            Console.WriteLine("   |     |    ");
            Console.WriteLine("___|_____|____");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("___|_____|____");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
        }

    }
}
