using System;

namespace Garage
{
    public class Zero  : Vehicle // Electric motorcycle
{
      // Create a class constructor with a parameter
      public Zero(string modelColor)
      {
          MainColor = modelColor;
      }
    public double BatteryKWh { get; set; }
    // public string MainColor { get; set; }
    // public string MaximumOccupancy { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

     public override void Drive()
    {
        Console.WriteLine($"\n The {MainColor} Zero zip by you. Yeeeeooooqqqq!");
    }


}
}