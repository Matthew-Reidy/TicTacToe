using System;

public class GenerateBoard
{
    public char[,] board = new char[5, 5];
    private int player1 = 0;
    private int player2 = 1;

    /*
     *     { 0 , |, 0 , | , 0 }
           { _ , |, }
     * 
    */


    public void setBoard() //initialize board at program start
    {
        board[0, 0] = '0';
        board[0, 1] = '|';
        board[0, 2] = '0';
        board[0, 3] = '|';
        board[0, 4] = '0';
        board[1, 0] = '_';
        board[1, 1] = '|';
        board[1, 2] = '_';
        board[1, 3] = '|';
        board[1, 4] = '_';
    }

    public void showBoard() //run at program start then run each time addToBoard is called
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                Console.Write(board[row, col]+ "\t");
                
            }
        }
    }
     public void addToBoard(int x, int y)  //while true in main run this placement determined by row, col coordinates 
     {
        if (isValidPlacement())
        {

        }
        else
        {
         Console.WriteLine("invalid placement");
        }

     }

    private bool isValidPlacement() //helper function of addToBoard
    {
        return true;
    }

}

