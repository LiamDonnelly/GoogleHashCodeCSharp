using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Problem
{
  public class Ride
  {
    //Public values
    public Point Start;
    public Point End;
    public int TotalDistance;

    public int _RideID = 0;
    public int Earliest = 0;
    public int Latest = 0;

    //Bonus
    public int StartBonus = 0;
    public int EndBonus = 0;


    TotalDistance = (End.x - Start.x) + (End.y - Start.y);


  }
}
