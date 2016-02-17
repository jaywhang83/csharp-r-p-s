using System;
using System.Linq;
using System.Collections.Generic;

namespace RPSNS
{
  public class RockPaperScissors
  {
    public string Play(string p1, string p2)
    {
      if((p1.Equals("rock") && p2.Equals("scissors")) || (p1.Equals("paper") && p2.Equals("rock")) || (p1.Equals("scissors") && p2.Equals("paper")))
      {
        return "player 1 wins";
      }
      else if((p2.Equals("rock") && p1.Equals("scissors")) || (p2.Equals("paper") && p1.Equals("rock")) || (p2.Equals("scissors") && p1.Equals("paper")))
      {
        return "player 2 wins";
      }
      else
      {
        return "draw";
      }
    }
  }
}
