namespace CodeRobot.Models
{
  public class CodeRobot
  {
    public int CurrentX { get; set; } = 5;
    public int CurrentY { get; set; } = 5;

    public bool MoveRobot(int left, int up)
    {
      CurrentX -= left;
      CurrentY -= up;
    }
  }
}