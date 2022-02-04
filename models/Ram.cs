using System;

namespace Garage
{
public class Ram: Vehicle, IGasVehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }

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

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram growls by you. Rrrrrrruuuummmmmmbbbble!");
    }
}
}