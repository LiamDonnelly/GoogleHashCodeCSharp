using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
  public class Car
  {
    //Public values

    public Point Position {get;set;}
    public List<Ride> Rides {get;set;}
    public int MovesRemaining {get;set;}
    public Point NextAvaliablePosition;

    //Private values
    private int _carID;

    void Car(int id)
    {
      _carID = id;
      FutureSets = new Dictionary<Ride,Point>();
    }

    public void AddRide(Ride ride)
    {
        int travelDistance = ride.distance + ((ride.Start.X - Position.X) +(ride.Start.Y - Position.Y));
        movesRemaining -= travelDistance;
        Rides.Add(ride);

        NextAvaliablePosition = new Point(ride.Finish);
    }

    //Return string of car Id and fare ID

    public string GetInfo()
    {
      Console.WriteLine(_carID, _RideID "this vehicle is assigned ", _carID, " rides: []", _RideID, "]") // Green text says "this vehicle is assigned " " rides: []" "]"
    }
  }
}
