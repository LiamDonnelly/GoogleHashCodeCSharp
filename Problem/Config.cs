using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
  public static class Config
  {
    public static int RowsNumber = 0;
     public static int CollumnsNumber = 0;
     public static int VehiclesNumber = 0;
     public static int RidesNumber = 0;
     public static int StartBonusNumber = 0;
     public static int StepsNumber = 0;

     public static int NumberOfRides = 0;
     public static List<Ride> Rides {get;set;} = new List<Ride>();

     public static void LoadFile(string filename)
     {
         using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open))
         using (System.IO.StreamReader inFile = new System.IO.StreamReader(fs))
         {
            RowsNumber = inFile.Read();
            CollumnsNumber = inFile.Read();
            VehiclesNumber = inFile.Read();
            RidesNumber = inFile.Read();
            StartBonusNumber = inFile.Read();
            StepsNumber = inFile.Read();

            int idCount = 0;
            for (int i = 0; i < RidesNumber; i++)
            {
              Ride r = new Ride();
              r.ID = idCount;
              r.Start.x = inFile.Read();
              r.Start.y = inFile.Read();

              r.End.x = inFile.Read();
              r.End.y = inFile.Read();

              r.StartBonus = inFile.Read();
              r.Latest = inFile.Read();
              Rides.Add(r);

              idCount++;
            }
         }
     }

     public static void WriteFile(string output, List<ICar> cars)
     {
        using (System.IO.FileStream sw = new System.IO.FileStream(output, System.IO.FileMode.OpenOrCreate))
        using (System.IO.StreamWriter outFile = new System.IO.StreamWriter(sw))
        {
          foreach(Car c in cars)
          {
            output.WriteLine(c.GetInfo());
          }
        }
     }
  }
}
