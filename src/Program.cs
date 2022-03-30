using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateBoard game = new GenerateBoard();
            rules();
            game.setBoard();
            game.showBoard();


        }
        
        static void rules()
        {
            Console.WriteLine("Rules: its tick tac toe lol");
        }
    }
}
