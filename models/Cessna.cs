using System;

namespace Garage
{
public class Cessna  : Vehicle, IGasVehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }
    // public string MainColor { get; set; }
    // public string MaximumOccupancy { get; set; }

public int CurrentTankPercentage {get; set;}
    public void RefuelTank()
    {
        if(CurrentTankPercentage<100)
        {
            CurrentTankPercentage = 100;
            }else {
              CurrentTankPercentage = 100;  
            }
    }

    public override void Drive ()
    {
        Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zzzzzoooooom!");
    }
}


}
