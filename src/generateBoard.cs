using System;
using System.Collections.Generic;

public class GenerateBoard
{

    //2d array gameboard
    public char[,] board = new char[5, 5];

    //determines whos turn it is based on player id
    private int turnKeeper = 0;

    private const int player1_id = 0;
    private const int player2_id = 1;
    //Maybe declaring player token as global var is not nescessary but it adds quick ability to change if needed...Best Practice?
    private const char player1_token = 'X';
    private const char player2_token = 'O';

    public void initBoard() //initialize board at program start also cleans the board at the start of new game
    {
        board[0, 0] = ' ';
        board[0, 1] = '|';
        board[0, 2] = ' ';
        board[0, 3] = '|';
        board[0, 4] = ' ';

        board[1, 0] = '-';
        board[1, 1] = '-';
        board[1, 2] = '-';
        board[1, 3] = '-';
        board[1, 4] = '-';

        board[2, 0] = ' ';
        board[2, 1] = '|';
        board[2, 2] = ' ';
        board[2, 3] = '|';
        board[2, 4] = ' ';

        board[3, 0] = '-';
        board[3, 1] = '-';
        board[3, 2] = '-';
        board[3, 3] = '-';
        board[3, 4] = '-';

        board[4, 0] = ' ';
        board[4, 1] = '|';
        board[4, 2] = ' ';
        board[4, 3] = '|';
        board[4, 4] = ' ';
    }

    public void showBoard() //run at program start then run each time addToBoard is called
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                Console.Write("{0,2}", board[row, col]);
                
            }
           Console.WriteLine();
        }
    }

     public void addToBoard(int x, int y)  //while true in main run this placement determined by row, col coordinates 
     {
       

        if (turnKeeper == player1_id && isValidPlacement(x, y, turnKeeper))
        {
            board[x, y] = player1_token;
            turnKeeper++;
            findWinnerOrDraw(player1_id , player1_token);
            Console.WriteLine("Player 2's turn");
        }
        else if (turnKeeper == player2_id && isValidPlacement(x, y, turnKeeper))
        {
            board[x, y] = player2_token;
            turnKeeper--;
            findWinnerOrDraw(player2_id , player2_token);
            Console.WriteLine("Player 1's turn");
        }
        else
        {
         Console.WriteLine("\ninvalid placement - please try again\n");
         
        }
        
     }

    private void findWinnerOrDraw( int player_id ,char token) //in progress
    {

        /*
         * TDOO: Check game board for a winner 
         * check columns
         * check rows
         * check horizontally from board[0,0] and board [0, 4]
        */
        int p1Sum = 0;
        int p2Sum = 0;

        for (int row = 0;row < board.GetLength(0); row++)
        {
            //check vertically
            
            for(int col = row; col < board.GetLength(1); col++)
            {
                //check horizontally
                if(p1Sum != 3 && p2Sum != 3)
                {
                    if (board[row, col] == '-' || board[row, col] == '|' || board[row, col] == ' ')
                    {
                        continue;

                    }
                    else
                    {
                        if (player_id == player1_id && token == player1_token)
                        {
                            
                            if (board[row, col] != player2_token)
                            {
                                p1Sum += 1;
                                Console.Write("curr pos " + board[row, col]);
                                Console.WriteLine("p1 sum" + p1Sum);
                            }
                            

                        }
                        else
                        {
                            if (board[row, col] != player1_token)
                            {
                                p2Sum += 1;
                                Console.Write("curr pos " + board[row, col]);
                                Console.WriteLine("p2 sum" + p1Sum);
                            }
                            p2Sum = 0;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Winner detected!");

                }
               
                
            }
        }

    }
 

    private bool isValidPlacement(int x, int y, int turnKeeper) //helper function of addToBoard
    {
        //if player tries to overwrite their own token
        if (board[x,y] == player1_token && turnKeeper == 1|| board[x, y] == player2_token && turnKeeper == 2)
        {
            return false;
        }
        //if one player tries to overwrite the others token
        else if (turnKeeper == 0 && board[x,y] == player2_token || turnKeeper == 1 && board[x, y] == player1_token)
        {
            return false;
        }
        //placement is valid. game flow continues
        return true;
    }

}

