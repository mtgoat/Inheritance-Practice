using System;

namespace Garage
{
public class Cessna  : Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }
    // public string MainColor { get; set; }
    // public string MaximumOccupancy { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive ()
    {
        Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zzzzzoooooom!");
    }
}


}
