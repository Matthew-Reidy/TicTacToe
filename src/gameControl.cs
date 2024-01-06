using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class gameControl
    {
        public bool activeGame = true;
        GenerateBoard game = new GenerateBoard();
        public void controlHub()
        {
            
            greeting();
            game.initBoard();
            
            while (activeGame) {
               
                game.showBoard();
                Console.WriteLine("\npick the square where you would like to place your peice");
               
                placementMenu();
               


            }


        }

        static void greeting() //simple greeting on program start...Contains rules.
        {
            Console.WriteLine("weclome to tic tac toe\n");
            Console.WriteLine("Rules:\nPlayer 1 goes first\n");

        }


        private void placementMenu()
        {
            try
            {
                int squareCoordinate = Convert.ToInt32(Console.ReadLine());
                
                switch (squareCoordinate)
                {
                    case 1:
                        game.addToBoard(0, 0);
                        break;
                    case 2:
                        game.addToBoard(0, 2);
                        break;
                    case 3:
                        game.addToBoard(0, 4);
                        break;
                    case 4:
                        game.addToBoard(2, 0);
                        break;
                    case 5:
                        game.addToBoard(2, 2);
                        break;
                    case 6:
                        game.addToBoard(2, 4);
                        break;
                    case 7:
                        game.addToBoard(4, 0);
                        break;
                    case 8:
                        game.addToBoard(4, 2);
                        break;
                    case 9:
                        game.addToBoard(4, 4);
                        break;
                }
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
         
            
        }

    }
}
