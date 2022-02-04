using System;

namespace Garage
{
    public class Zero  : Vehicle, IElectricVehicle // Electric motorcycle
{
      // Create a class constructor with a parameter
      public Zero(string modelColor)
      {
          MainColor = modelColor;
      }

    public double BatteryKWh { get; set; }
    // public string MainColor { get; set; }
    // public string MaximumOccupancy { get; set; }

    public int CurrentChargePercentage { get; set;} 
    public void ChargeBattery()
    {
          if (CurrentChargePercentage< 100)
        {
            CurrentChargePercentage = 100;
        }
        else {
            CurrentChargePercentage = 100;
        }
    }

     public override void Drive()
    {
        Console.WriteLine($"\n The {MainColor} Zero zip by you. Yeeeeooooqqqq!");
    }


}
}