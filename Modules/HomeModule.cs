using Nancy;
using System;
using System.Collections.Generic;

namespace RPSNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/result"] = _ => {
        
        string p1 = Request.Form["p1"];
        string p2 = Request.Form["p2"];
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        RockPaperScissors newRPS = new RockPaperScissors();
        return View["result.cshtml",  newRPS.Play(p1, p2)];

      };
    }
  }
}
