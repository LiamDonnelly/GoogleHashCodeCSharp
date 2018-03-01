using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Problem
{
    public class Ride
    {
      public int Id {get;set;}
      public int Distance {get;set;}
      public int Earliest { get; set; }
      public int Latest {get;set;}
      public System.Drawing.Point Start {get;set;}
      public System.Drawing.Point End {get;set;}
    }

    public class TestCar
    {
      public int Id {get;set;}
      public int Score {get;set;}
      public System.Drawing.Point Position {get;set;}
      public List<IRide> Rides {get;set;}
      public int movesRemaining {get;set;}

      public void AddRide(Ride ride)
      {
          int travelDistance = ride.distance + ((ride.Start.X - Position.X) +(ride.Start.Y - Position.Y));
          movesRemaining -= travelDistance;
          Rides.Add(ride);
      }
    }

    class Program
    {
        static void Main(string[] args)
        {
          // Read Data
          int currentStep = 0;
          int simSteps = 100;

          Problem.Config.LoadFile("a_example.in");
          //Problem.Config.LoadFile("b_should_be_easy.in");
          //Problem.Config.LoadFile("c_no_hurry.in");
          //Problem.Config.LoadFile("d_metropolis.in");
          //Problem.Config.LoadFile("e_high_bonus.in");

          List<Car> cars = new List<Car>();
          List<Rides> fares = new List<Rides>();

          //Sort Rides on Bonus Start Time
          fares.OrderBy(f => f.Earliest);

          int c = 0;
          foreach(Car car in cars)
          {
            car.AddRide(fares[c])
            c++;
          }
          fares.RemoveRange(0, cars.Count);

          foreach(Ride fare in fares)
          {
              //find lowest travelcost
              Car closest = null;
              int travelcost = Int32.MaxValue;
              foreach(TestCar car in cars)
              {
                int travelDistance = fare.distance + ((fare.Start.X - car.NextAvaliablePosition.X) +(fare.Start.Y - car.NextAvaliablePosition.Y))
                if(travelDistance < travelcost && car.MovesRemaining > travelDistance)
                {
                    travelcost = travelDistance;
                    closest = car;
                }
              }
              car.AddRide(fare);
          }

          Problem.Config.WriteFile("output.txt", cars);
        }

        private int DistanceBetweenPoints(System.Drawing.Point p1, System.Drawing.Point p2)
        {
          return (p1.x - p2.x ) + (p1.y - p2.y);
        }
    }
}
