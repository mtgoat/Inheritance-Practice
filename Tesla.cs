using System;

namespace Garage
{
    //To inherit from a class, use the : symbol and followed by the name of the base class.
    //In the example below, the Tesla class (child) inherits the fields and methods from the Vehicle class (parent):
public class Tesla : Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }
    // public string MainColor { get; set; }
    // public string MaximumOccupancy { get; set; }
    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive ()
    {
        Console.WriteLine($"The {MainColor} Tesla blazes by you. MMmmmmmmmmmm!");
    }
}


}