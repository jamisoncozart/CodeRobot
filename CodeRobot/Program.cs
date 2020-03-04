using System;
using CodeRobot.Models;

public class Program
{
  public static void Main()
  {
    Game newGame = new Game();
    Console.WriteLine(newGame.ConvertBoardToString());
  }
}