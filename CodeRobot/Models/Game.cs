namespace CodeRobot.Models
{
  public class Game
  {
    private char[,] _board = 
    {
      { ' ', ' ', ' ', ' ', ' ' },
      { ' ', ' ', ' ', ' ', ' ' },
      { ' ', ' ', ' ', ' ', ' ' },
      { ' ', ' ', ' ', ' ', ' ' },
      { ' ', ' ', ' ', ' ', ' ' }
    };

    public string ConvertBoardToString()
    {
      string boardString = $"-----------\n|{_board[0,0]}|{_board[0,1]}|{_board[0,2]}|{_board[0,3]}|{_board[0,4]}|\n-----------\n|{_board[1,0]}|{_board[1,1]}|{_board[1,2]}|{_board[1,3]}|{_board[1,4]}|\n-----------\n|{_board[2,0]}|{_board[2,1]}|{_board[2,2]}|{_board[2,3]}|{_board[2,4]}|\n-----------\n|{_board[3,0]}|{_board[3,1]}|{_board[3,2]}|{_board[3,3]}|{_board[3,4]}|\n-----------\n|{_board[4,0]}|{_board[4,1]}|{_board[4,2]}|{_board[4,3]}|{_board[4,4]}|\n-----------";
      return boardString;
    }
  }
}