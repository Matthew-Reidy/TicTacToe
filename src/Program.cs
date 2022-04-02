using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateBoard game = new GenerateBoard();
            greeting();

            game.initBoard();
            Console.WriteLine("Enter the x,y coordinates of where you want to place your peice");
            game.addToBoard(0,0);
            game.showBoard();

            


        }
        
        static void greeting()
        {
            Console.WriteLine("weclome to tic tac toe\n");
            Console.WriteLine("Rules:\nPlayer 1 goes first\n");
        }
    }
}
