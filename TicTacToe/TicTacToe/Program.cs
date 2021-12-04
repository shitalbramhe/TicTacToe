using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe");
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.Creatboard();
            ticTacToeGame.Gameinput();
            ticTacToeGame.Showboard();
        }
    }
}