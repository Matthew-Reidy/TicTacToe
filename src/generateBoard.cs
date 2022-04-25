using System;
using System.Collections.Generic;

public class GenerateBoard
{

    //2d array gameboard
    public char[,] board = new char[5, 5];
   
    //determines whos turn it is based on player id
    public int  turnKeeper = 0;
   
    public int player1_id = 0;
    public int player2_id = 1;
    //Maybe declaring player token as global var is not nescessary but it adds quick ability to change if needed...Best Practice?
    public char player1_token = 'X';
    public char player2_token = 'O';

    public void initBoard() //initialize board at program start also cleans the board at the start of new game
    {
        board[0, 0] = '0';
        board[0, 1] = '|';
        board[0, 2] = '0';
        board[0, 3] = '|';
        board[0, 4] = '0';

        board[1, 0] = '-';
        board[1, 1] = '-';
        board[1, 2] = '-';
        board[1, 3] = '-';
        board[1, 4] = '-';

        board[2, 0] = '0';
        board[2, 1] = '|';
        board[2, 2] = '0';
        board[2, 3] = '|';
        board[2, 4] = '0';

        board[3, 0] = '-';
        board[3, 1] = '-';
        board[3, 2] = '-';
        board[3, 3] = '-';
        board[3, 4] = '-';

        board[4, 0] = '0';
        board[4, 1] = '|';
        board[4, 2] = '0';
        board[4, 3] = '|';
        board[4, 4] = '0';
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
            
            Console.WriteLine("Player 2's turn");
        }
        else if (turnKeeper == player2_id && isValidPlacement(x, y, turnKeeper))
        {
            board[x, y] = player2_token;
            turnKeeper--;
            
            Console.WriteLine("Player 1's turn");
        }
        else
        {
         Console.WriteLine("\ninvalid placement - please try again\n");
         
        }

     }

    public void findWinnerOrDraw() //in progress
    {
      
        //Dictionary<int, int> map = new Dictionary<int, int>();
        for (int row =0; row<board.GetLength(0); row++)
        {
            for(int col =0; row<board.GetLength(1); col++)
            {
                if(board[row,col] == '|' || board[row,col] == '-')
                {
                    continue;
                }

                if (board[row, col-2] == player1_token )
                {
                    Console.WriteLine("game over- we have a winner");
                }
                

            }
        }

    }

    private void DFS(int row, int col)
    {



        DFS(row -2, col);
        DFS(row, col -2);

    }

    private bool isValidPlacement(int x, int y, int turnKeeper) //helper function of addToBoard
    {
        if (board[x,y] == '|' || board[x, y] == '-')
        {
            return false;
        }
        else if (turnKeeper == 0 && board[x,y] == player2_token || turnKeeper == 1 && board[x, y] == player1_token)
        {
            return false;
        }

        return true;
    }

    private bool winningCondition()
    {
        return true;
    }

